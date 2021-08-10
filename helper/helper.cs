using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Threading;

namespace mass_groundstation_v2.helper
{
    public static class helper
    {
        public static PingReply ping_ip(string ip)
        {
            Ping p = new Ping();
            PingReply r = p.Send(ip);
            return r;
        }

        public static void change_label(Label lbl, string text, Color col)
        {
            if (lbl.InvokeRequired)
            {
                lbl.Invoke((MethodInvoker)delegate
                {
                    lbl.Text = text;
                    lbl.ForeColor = col;
                });
            }
            else
            {
                lbl.Text = text;
                lbl.ForeColor = col;
            }
        }

        public static void change_label(ToolStripStatusLabel lbl, string text, Color col)
        {          
            if (lbl.GetCurrentParent().InvokeRequired)
            {
                lbl.GetCurrentParent().Invoke((MethodInvoker)delegate
                {
                    lbl.Text = text;
                    lbl.ForeColor = col;
                });
            }
            else
            {
                lbl.Text = text;
                lbl.ForeColor = col;
            }
        }

        public static void change_text_box(TextBox tb,string text)
        {
            if (tb.InvokeRequired)
            {
                tb.Invoke((MethodInvoker)delegate
                {
                    tb.Text = text;
                });
            }
            else
            {
                tb.Text = text;
            }
        }
        private static void write_log(string log, string log_path = @"C:\Log.txt")
        {
            using (StreamWriter sw = new StreamWriter(log_path, true))
            {
                sw.WriteLine(log);
            }
        }

        public static void chart_add_xy(System.Windows.Forms.DataVisualization.Charting.Chart chart,string series, TimeSpan x, float y)
        {
            if (chart.InvokeRequired)
            {
                chart.Invoke((MethodInvoker)delegate
                {
                    chart.Series[series].Points.AddXY(new DateTime() + x, y);
                });
            }
            else
            {
                chart.Series[series].Points.AddXY(new DateTime() + x, y);
            }           
        }



        public static void print_log(string message)
        {
            string output_text = DateTime.Now.ToString("HH:mm:ss  -  ") + message; // add time to output
            RichTextBox rtb = Program.main_form.rtbLogs;

            if(Program.main_form.cbLogsEnableLogFile.Checked)
            {               
                write_log(output_text, Path.Combine("C:\\bexus_logs\\" + Program.application_start_time, "log_file_" + Program.application_start_time + ".txt"));
                write_log(output_text,Path.Combine(Program.application_path + "\\" + Program.application_start_time, "log_file_" + Program.application_start_time + ".txt"));
            }

            if (rtb.InvokeRequired)
            {
                rtb.Invoke((MethodInvoker)delegate
                {
                    rtb.AppendText(output_text);  // add text to OutputTextBox
                    rtb.AppendText(Environment.NewLine); // new line
                    Program.main_form.statusStripLabelLog.Text = output_text;
                    Program.main_form.statusStrip.Refresh();

                });
            }
            else
            {
                rtb.AppendText(output_text);  // add text to OutputTextBox
                rtb.AppendText(Environment.NewLine); // new line
                Program.main_form.statusStripLabelLog.Text = output_text;
                Program.main_form.statusStrip.Refresh();
            }


        }
    }

}
