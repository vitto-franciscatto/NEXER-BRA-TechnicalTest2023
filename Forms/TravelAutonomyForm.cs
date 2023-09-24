namespace TesteTecnico2023.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TesteTecnico2023.Model;

    public partial class TravelAutonomyForm : Form
    {
        public TravelAutonomyForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool isValidDistance = double.TryParse(txtDistance.Text, out double selectedDistance);
            bool isValidWeight = double.TryParse(txtWeight.Text, out double selectedWeight);

            Vehicle cheapestVehicle = null;
            double travelCost = 0d;
            List<Tuple<Vehicle, double>> vehicleCosts = new List<Tuple<Vehicle, double>>();

            if(isValidDistance && isValidWeight)
            {
                foreach(var item in Data.VEHICLES.Select((value, i) => new { i, value }))
                {
                    double? vehicleFuelPrice = Data.FUEL_PRICES.FirstOrDefault(x => x.name == item.value.Fuel)?.price;
                    if(vehicleFuelPrice is null)
                    {
                        continue;
                    }

                    double vehicleTravelCost = item.value.GetTravelCost(selectedDistance, selectedWeight, vehicleFuelPrice.Value);

                    vehicleCosts.Add(new Tuple<Vehicle, double>(item.value, vehicleTravelCost));
                }
            }

            if (vehicleCosts != null)
            {
                vehicleCosts.Sort(delegate (Tuple<Vehicle, double> t1, Tuple<Vehicle, double> t2) { return t1.Item2.CompareTo(t2.Item2); });
            }

            cheapestVehicle = vehicleCosts.FirstOrDefault()?.Item1;
            travelCost = vehicleCosts.FirstOrDefault()?.Item2 ?? 0;

            using (TravelAutonomyResult travelAutonomyResult = new TravelAutonomyResult(
                cheapestVehicle?.Type().ToUpper() ?? "ERRO", 
                cheapestVehicle?.Brand.ToUpper() ?? "ERRO", 
                cheapestVehicle?.ModelName.ToUpper() ?? "ERRO", 
                travelCost.ToString("C", new CultureInfo("pt-BR")))) 
            {
                travelAutonomyResult.ShowDialog();
            }
        }
    }
}
