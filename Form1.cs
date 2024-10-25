using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic_10_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void EnableButtons()
        {
            btnSun.Enabled = true;
            btnMercury.Enabled = true;
            btnVenus.Enabled = true;
            btnEarth.Enabled = true;
            btnMars.Enabled = true;
            btnJupiter.Enabled = true;
            btnSaturn.Enabled = true;
            btnUranus.Enabled = true;
            btnNeptune.Enabled = true;
            lblStart.Visible = false;
            lblInfo.Visible = true;
        }

        private void btnSun_Click(object sender, EventArgs e)
        {
            EnableButtons();
            btnSun.Enabled = false;
            imgPlanet.Image = Properties.Resources.sun;
            lblInfo.Text = "The Sun's surface temperature is 5600 degrees Celsius. Our Sun is the most important celestial body that we have in the Solar System. The sun controls the gravity of the Solar System, which is why many asteroids or planets have the orbits that they have.";
        }

        private void btnMercury_Click(object sender, EventArgs e)
        {
            EnableButtons();
            btnMercury.Enabled = false;
            imgPlanet.Image = Properties.Resources.mercury;
            lblInfo.Text = "Mercury is the first and smallest planet in the Solar System, as small as Earth's moon. Mercury has the thinnest atmosphere in the Solar System, and holds a gigantic iron core. It's surface consists of many impact craters, making it a survivor to some.";
        }

        private void btnVenus_Click(object sender, EventArgs e)
        {
            EnableButtons();
            btnVenus.Enabled = false;
            imgPlanet.Image = Properties.Resources.venus;
            lblInfo.Text = "Venus is the second planet from the Sun, and also the hottest planet in the Solar System. Venus's surface temperature is 464 degrees Celsius. Venus's atmosphere is increasingly thick, full of carbon dioxide, and sulphuric acid. Fun Fact: A day on Venus (243 Earth Days) is longer than a year on Venus (225 Earth Days)!";
        }

        private void btnEarth_Click(object sender, EventArgs e)
        {
            EnableButtons();
            btnEarth.Enabled = false;
            imgPlanet.Image = Properties.Resources.earth;
            lblInfo.Text = "Earth is the third planet from the Sun, and the fifth largest planet overall, with being the only planet to support life. Earth is also the only planet to not be named after a God. Earth is named after.... the ground. Earth has a moon, called \"The Moon\". The Ocean contains 97% of Earth's water!";
        }

        private void btnMars_Click(object sender, EventArgs e)
        {
            EnableButtons();
            btnMars.Enabled = false;
            imgPlanet.Image = Properties.Resources.mars;
            lblInfo.Text = "Mars is the fourth planet from the Sun, and is deemed to be one of the most explored bodies in the Solar System. Scientists believe that Mars used to be steaming with life, but isn't anymore. Mars has two moons, Phobos and Deimos. Phobos is estimated to crash into Mars in 50 million years, and could potentially give Mars some rings!";
        }

        private void btnJupiter_Click(object sender, EventArgs e)
        {
            EnableButtons();
            btnJupiter.Enabled = false;
            imgPlanet.Image = Properties.Resources.jupiter;
            lblInfo.Text = "Jupiter is the fifth planet from the sun, a gas giant at best, and the largest planet overall. Jupiter was formed 4.6 billion years ago, and has the shortest day ever! Jupiter has 95 moons, the largest ones being Europa, Ganymede, IO, and Callisto. Jupiter also has rings, but they're difficult to notice. Jupiter's Great Red Spot, is twice the size of Earth, 435 km/h winds, and is the largest known 'storm' in the Solar System!";
        }

        private void btnSaturn_Click(object sender, EventArgs e)
        {
            EnableButtons();
            btnSaturn.Enabled = false;
            imgPlanet.Image = Properties.Resources.saturn;
            lblInfo.Text = 
        }
    }
}
