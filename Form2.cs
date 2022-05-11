using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace student_project
{
    public partial class Form2 : Form
    {
        //Location of the database
        SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\KK\\Desktop\\DATA.db");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL command to get data 
            string querry = "SELECT AAS.ID, AAS.COUNTRY, " +
                "AAS.Y1990 * CHAR.AAS + CD.Y1990 * CHAR.CD + CR.Y1990 * CHAR.CR + CU.Y1990 * CHAR.CU + HG.Y1990 * CHAR.HG + NI.Y1990 * CHAR.NI + PB.Y1990 * CHAR.PB + SE.Y1990 * CHAR.SE + ZN.Y1990 * CHAR.ZN AS TOXICITYof1990," +
                "AAS.Y1995 * CHAR.AAS + CD.Y1995 * CHAR.CD + CR.Y1995 * CHAR.CR + CU.Y1995 * CHAR.CU + HG.Y1995 * CHAR.HG + NI.Y1995 * CHAR.NI + PB.Y1995 * CHAR.PB + SE.Y1995 * CHAR.SE + ZN.Y1995 * CHAR.ZN AS TOXICITYof1995," +
                "AAS.Y2000 * CHAR.AAS + CD.Y2000 * CHAR.CD + CR.Y2000 * CHAR.CR + CU.Y2000 * CHAR.CU + HG.Y2000 * CHAR.HG + NI.Y2000 * CHAR.NI + PB.Y2000 * CHAR.PB + SE.Y2000 * CHAR.SE + ZN.Y2000 * CHAR.ZN AS TOXICITYof2000," +
                "AAS.Y2005 * CHAR.AAS + CD.Y2005 * CHAR.CD + CR.Y2005 * CHAR.CR + CU.Y2005 * CHAR.CU + HG.Y2005 * CHAR.HG + NI.Y2005 * CHAR.NI + PB.Y2005 * CHAR.PB + SE.Y2005 * CHAR.SE + ZN.Y2005 * CHAR.ZN AS TOXICITYof2005," +
                "AAS.Y2010 * CHAR.AAS + CD.Y2010 * CHAR.CD + CR.Y2010 * CHAR.CR + CU.Y2010 * CHAR.CU + HG.Y2010 * CHAR.HG + NI.Y2010 * CHAR.NI + PB.Y2010 * CHAR.PB + SE.Y2010 * CHAR.SE + ZN.Y2010 * CHAR.ZN AS TOXICITYof2010," +
                "AAS.Y2011 * CHAR.AAS + CD.Y2011 * CHAR.CD + CR.Y2011 * CHAR.CR + CU.Y2011 * CHAR.CU + HG.Y2011 * CHAR.HG + NI.Y2011 * CHAR.NI + PB.Y2011 * CHAR.PB + SE.Y2011 * CHAR.SE + ZN.Y2011 * CHAR.ZN AS TOXICITYof2011," +
                "AAS.Y2012 * CHAR.AAS + CD.Y2012 * CHAR.CD + CR.Y2012 * CHAR.CR + CU.Y2012 * CHAR.CU + HG.Y2012 * CHAR.HG + NI.Y2012 * CHAR.NI + PB.Y2012 * CHAR.PB + SE.Y2012 * CHAR.SE + ZN.Y2012 * CHAR.ZN AS TOXICITYof2012," +
                "AAS.Y2013 * CHAR.AAS + CD.Y2013 * CHAR.CD + CR.Y2013 * CHAR.CR + CU.Y2013 * CHAR.CU + HG.Y2013 * CHAR.HG + NI.Y2013 * CHAR.NI + PB.Y2013 * CHAR.PB + SE.Y2013 * CHAR.SE + ZN.Y2013 * CHAR.ZN AS TOXICITYof2013," +
                "AAS.Y2014 * CHAR.AAS + CD.Y2014 * CHAR.CD + CR.Y2014 * CHAR.CR + CU.Y2014 * CHAR.CU + HG.Y2014 * CHAR.HG + NI.Y2014 * CHAR.NI + PB.Y2014 * CHAR.PB + SE.Y2014 * CHAR.SE + ZN.Y2014 * CHAR.ZN AS TOXICITYof2014," +
                "AAS.Y2015 * CHAR.AAS + CD.Y2015 * CHAR.CD + CR.Y2015 * CHAR.CR + CU.Y2015 * CHAR.CU + HG.Y2015 * CHAR.HG + NI.Y2015 * CHAR.NI + PB.Y2015 * CHAR.PB + SE.Y2015 * CHAR.SE + ZN.Y2015 * CHAR.ZN AS TOXICITYof2015," +
                "AAS.Y2016 * CHAR.AAS + CD.Y2016 * CHAR.CD + CR.Y2016 * CHAR.CR + CU.Y2016 * CHAR.CU + HG.Y2016 * CHAR.HG + NI.Y2016 * CHAR.NI + PB.Y2016 * CHAR.PB + SE.Y2016 * CHAR.SE + ZN.Y2016 * CHAR.ZN AS TOXICITYof2016," +
                "AAS.Y2017 * CHAR.AAS + CD.Y2017 * CHAR.CD + CR.Y2017 * CHAR.CR + CU.Y2017 * CHAR.CU + HG.Y2017 * CHAR.HG + NI.Y2017 * CHAR.NI + PB.Y2017 * CHAR.PB + SE.Y2017 * CHAR.SE + ZN.Y2017 * CHAR.ZN AS TOXICITYof2017," +
                "AAS.Y2018 * CHAR.AAS + CD.Y2018 * CHAR.CD + CR.Y2018 * CHAR.CR + CU.Y2018 * CHAR.CU + HG.Y2018 * CHAR.HG + NI.Y2018 * CHAR.NI + PB.Y2018 * CHAR.PB + SE.Y2018 * CHAR.SE + ZN.Y2018 * CHAR.ZN AS TOXICITYof2018," +
                "AAS.Y2019 * CHAR.AAS + CD.Y2019 * CHAR.CD + CR.Y2019 * CHAR.CR + CU.Y2019 * CHAR.CU + HG.Y2019 * CHAR.HG + NI.Y2019 * CHAR.NI + PB.Y2019 * CHAR.PB + SE.Y2019 * CHAR.SE + ZN.Y2019 * CHAR.ZN AS TOXICITYof2019 " +
                
                "FROM AAS, CD, CR, CU, HG, NI, PB, SE, ZN, CHAR " +
                "WHERE CD.COUNTRY = AAS.COUNTRY AND CR.COUNTRY = AAS.COUNTRY AND CU.COUNTRY = AAS.COUNTRY AND HG.COUNTRY = AAS.COUNTRY AND NI.COUNTRY = AAS.COUNTRY AND PB.COUNTRY = AAS.COUNTRY AND SE.COUNTRY = AAS.COUNTRY AND ZN.COUNTRY = AAS.COUNTRY";

            //Does the command on the given database
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            //Creates new empty datatable to store stuff
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            //Fills up the datatable
            adapter.Fill(dt);

            //Sets datagridview1 source as filled up datatable
            dataGridView1.DataSource = dt;
        }
    }
}
