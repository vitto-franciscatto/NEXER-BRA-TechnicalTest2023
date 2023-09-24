using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteTecnico2023.Model;

namespace TesteTecnico2023.Forms
{
    public partial class TravelAutonomyResult : Form
    {
        private readonly string _vehicleType = string.Empty;
        private readonly string _vehicleBrand = string.Empty;
        private readonly string _vehicleModel = string.Empty;
        private readonly string _vehicleTravelCost = string.Empty;
        public TravelAutonomyResult(
            string vehicleType, 
            string vehicleBrand, 
            string vehicleModel, 
            string vehicleTravelCost)
        {
            InitializeComponent();
            _vehicleType = vehicleType;
            _vehicleBrand = vehicleBrand;
            _vehicleModel = vehicleModel;
            _vehicleTravelCost = vehicleTravelCost;
        }

        private void LowerCostVehicle_Load(object sender, EventArgs e)
        {
            tbType.Text = _vehicleType;
            tbBrand.Text = _vehicleBrand;
            tbModel.Text = _vehicleModel;
            tbCost.Text = _vehicleTravelCost;
        }
    }
}