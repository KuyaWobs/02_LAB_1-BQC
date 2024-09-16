    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace _02_LAB_1_BQC
    {
        public partial class CashierWindowQueueForm : Form
        {
            public CashierWindowQueueForm()
            {
                InitializeComponent();

                Timer timer = new Timer();
                timer.Interval = (1 * 1000);
    timer.Tick += new EventHandler(timer1_tick);
                timer.Start();
            }

            public void DisplayCashierQueue(IEnumerable CashierList)
            {
                listCashierQueue.Items.Clear();
                foreach (Object obj in CashierList)
                {
                    listCashierQueue.Items.Add(obj.ToString());
                }
            }

            private void btnRefresh_Click(object sender, EventArgs e)
            {
                DisplayCashierQueue(CashierClass.CashierQueue);

            }

            public void timer1_tick(object sender, EventArgs e)
            {
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
        }
    }
