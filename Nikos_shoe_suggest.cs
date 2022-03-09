using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_home
{
    public partial class Nikos_shoe_suggest : Form
    {
        string today = Form1.day;
        int TimeNow = Form1.time;
        string Good1= Nikos_shoe_rack_ViewShoesKind.leather_black_good;
        string Athletic1=Nikos_shoe_rack_ViewShoesKind.jays_black_active;
        string Athletic2= Nikos_shoe_rack_ViewShoesKind.jays_grey_active;
        string Chill1= Nikos_shoe_rack_ViewShoesKind.lacoste_chill;
        string Chill2= Nikos_shoe_rack_ViewShoesKind.converse_chill;

        public Nikos_shoe_suggest()
        {
            InitializeComponent();
        }

        private void onlineHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nikos_shoe_rack rack = new Nikos_shoe_rack();
            rack.Show();
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nikos_shoe_suggest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(today=="Monday" & Nikos_personal_assistant.monday_has_plan==true)
            {
                if (TimeNow == 6)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type6 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type6 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type6 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 7)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type7 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type7 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type7 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 8)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type8 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type8 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type8 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 9)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type9 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type9 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type9 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 10)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type10 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type10 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type10 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 11)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type11 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type11 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type11 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 12)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type12 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type12 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type12 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 13)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type13 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type13 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type13 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 14)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type14 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type14 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type14 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 15)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type15 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type15 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                    if (Nikos_assistant_activities_choosing.monday_activity_type15 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 16)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type16 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type16 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type16 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 17)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type17 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type17 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type17 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 18)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type18 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type18 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type18 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 19)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type19 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type19 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 20)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type20 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type20 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type20 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 21)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type21 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type21 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type21 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 22)
                {
                    if (Nikos_assistant_activities_choosing.monday_activity_type22 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type22 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.monday_activity_type22 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                    }


                }



            }
            if (today == "Tuesday" & Nikos_personal_assistant.tuesday_has_plan==true)
            {
                if (TimeNow == 6)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type6 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type6 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type6 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 7)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type7 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type7 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type7 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 8)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type8 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type8 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type8 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 9)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type9 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type9 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type9 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 10)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type10 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type10 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type10 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 11)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type11 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type11 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type11 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 12)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type12 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type12 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type12 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 13)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type13 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type13 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type13 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 14)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type14 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type14 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type14 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 15)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type15 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type15 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                    if (Nikos_assistant_activities_choosing.tuesday_activity_type15 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 16)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type16 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type16 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type16 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 17)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type17 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type17 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type17 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 18)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type18 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type18 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type18 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 19)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type19 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type19 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 20)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type20 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type20 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type20 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 21)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type21 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type21 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type21 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 22)
                {
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type22 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type22 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.tuesday_activity_type22 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                    }


                }
            }
            if (today == "Wednesday" & Nikos_personal_assistant.wednesday_has_plan == true)
            {
                if (TimeNow == 6)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type6 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type6 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type6 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 7)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type7 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type7 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type7 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 8)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type8 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type8 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type8 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 9)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type9 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type9 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type9 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 10)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type10 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type10 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type10 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 11)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type11 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type11 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type11 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 12)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type12 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type12 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type12 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 13)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type13 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type13 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type13 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 14)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type14 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type14 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type14 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 15)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type15 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type15 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                    if (Nikos_assistant_activities_choosing.wednesday_activity_type15 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 16)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type16 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type16 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type16 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 17)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type17 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type17 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type17 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 18)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type18 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type18 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type18 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 19)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type19 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type19 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 20)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type20 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type20 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type20 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 21)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type21 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type21 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type21 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 22)
                {
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type22 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type22 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.wednesday_activity_type22 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                    }


                }


            }
            if (today == "Thursday" & Nikos_personal_assistant.thursday_has_plan == true)
            {
                if (TimeNow == 6)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type6 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type6 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type6 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 7)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type7 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type7 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type7 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 8)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type8 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type8 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type8 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 9)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type9 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type9 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type9 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 10)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type10 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type10 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type10 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 11)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type11 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type11 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type11 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 12)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type12 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type12 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type12 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 13)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type13 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type13 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type13 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 14)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type14 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type14 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type14 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 15)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type15 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type15 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                    if (Nikos_assistant_activities_choosing.thursday_activity_type15 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 16)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type16 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type16 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type16 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 17)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type17 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type17 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type17 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 18)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type18 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type18 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type18 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 19)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type19 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type19 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 20)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type20 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type20 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type20 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 21)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type21 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type21 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type21 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 22)
                {
                    if (Nikos_assistant_activities_choosing.thursday_activity_type22 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type22 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.thursday_activity_type22 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                    }


                }
            }
            if (today == "Friday" & Nikos_personal_assistant.friday_has_plan == true)
            {
                if (TimeNow == 6)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type6 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type6 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type6 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 7)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type7 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type7 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type7 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 8)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type8 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type8 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type8 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 9)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type9 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type9 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type9 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 10)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type10 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type10 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type10 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 11)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type11 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type11 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type11 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 12)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type12 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type12 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type12 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 13)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type13 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type13 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type13 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 14)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type14 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type14 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type14 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 15)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type15 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type15 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                    if (Nikos_assistant_activities_choosing.friday_activity_type15 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 16)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type16 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type16 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type16 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 17)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type17 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type17 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type17 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 18)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type18 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type18 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type18 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 19)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type19 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type19 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 20)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type20 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type20 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type20 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 21)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type21 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type21 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type21 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 22)
                {
                    if (Nikos_assistant_activities_choosing.friday_activity_type22 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type22 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.friday_activity_type22 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                    }


                }

            }
            if (today == "Saturday" & Nikos_personal_assistant.saturday_has_plan == true)
            {
                if (TimeNow == 6)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type6 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type6 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type6 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 7)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type7 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type7 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type7 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 8)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type8 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type8 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type8 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 9)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type9 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type9 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type9 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 10)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type10 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type10 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type10 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 11)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type11 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type11 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type11 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 12)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type12 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type12 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type12 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 13)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type13 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type13 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type13 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 14)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type14 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type14 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type14 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 15)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type15 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type15 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                    if (Nikos_assistant_activities_choosing.saturday_activity_type15 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 16)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type16 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type16 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type16 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 17)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type17 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type17 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type17 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 18)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type18 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type18 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type18 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 19)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type19 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type19 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 20)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type20 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type20 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type20 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 21)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type21 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type21 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type21 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 22)
                {
                    if (Nikos_assistant_activities_choosing.saturday_activity_type22 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type22 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.saturday_activity_type22 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                    }


                }
            }
            if (today == "Sunday" & Nikos_personal_assistant.sunday_has_plan == true)
            {
                if (TimeNow == 6)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type6 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type6 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type6 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 7)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type7 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type7 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type7 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 8)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type8 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type8 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type8 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 9)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type9 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type9 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type9 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 10)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type10 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type10 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type10== "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 11)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type11 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type11 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type11 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 12)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type12 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type12 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type12== "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 13)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type13 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type13 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type13 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 14)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type14 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type14 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type14 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 15)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type15 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type15 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }

                    
                    if (Nikos_assistant_activities_choosing.sunday_activity_type15 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 16)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type16 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type16 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type16 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 17)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type17 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type17 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type17 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 18)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type18 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type18 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type18 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 19)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type19 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type19 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 20)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type20 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type20 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type20 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 21)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type21 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type21 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type21   == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();
                    }


                }
                if (TimeNow == 22)
                {
                    if (Nikos_assistant_activities_choosing.sunday_activity_type22 == "Επίσημο")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι επίσημη οπότε προτείνουμε:" + Good1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type22 == "Αθλητικό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι αθλητική οπότε προτείνουμε:" + Athletic2 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    if (Nikos_assistant_activities_choosing.sunday_activity_type22 == "Χαλαρό")
                    {
                        MessageBox.Show("Φαίνεται ότι ο τύπος δραστηριότητας είναι χαλαρή οπότε προτείνουμε:" + Chill1 + "");
                        this.Close();
                        Nikos_shoe_rack ra = new Nikos_shoe_rack();
                        ra.Show();

                    }
                    else
                    {
                        MessageBox.Show("Φαίνεται ότι δεν έχετε κάποια δραστηριότητα αυτήν την ώρα, ανακατεύθυνση στην προηγούμενη φόρμα");
                    }


                }
            }
            else 
            {
                MessageBox.Show("Φαίνεται να μην έχετε πρόγραμμα για αυτήν την ημέρα, ανακατευθηνεστε στο πλάνο");
                this.Close();
                Nikos_assistant_activities_choosing cho = new Nikos_assistant_activities_choosing("no idea", 2);
                cho.Show();

            }
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            richTextBox5.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            richTextBox5.Visible = false;
        }
    }
}
