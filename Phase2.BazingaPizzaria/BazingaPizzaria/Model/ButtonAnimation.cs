using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BazingaPizzaria;

namespace BazingaPizzaria.Model
{
    public static class ButtonAnimation
    {

        //Group of selection buttons must be in a group box together in 
        //order for this method to work.
        public static void ButtonSelect(FormMain form, Button button)
        {
            // Find all TabControls on the form
            foreach (var tab in form.Controls.OfType<TabControl>())
            {
                // Find all TabPages in this TabControl
                foreach (var page in tab.Controls.OfType<TabPage>())
                {
                    // Find all GroupBoxes in this tab
                    foreach (var gb in page.Controls.OfType<GroupBox>())
                    {
                        // Is this the GroupBox that contains parameter button?
                        if (gb.Contains(button))
                        {
                            // Change all of the buttons in this GroupBox
                            foreach (var b in gb.Controls.OfType<Button>())
                            {
                                b.BackColor = form.colRed;
                            }
                        }
                    }
                }
            }

            // Highlight the selected button
            button.BackColor = form.colDarkBlue;
        }

        // For selection buttons that are in a tab within a tab
        public static void ButtonSelectInnerTab(FormMain form, Button button)
        {
            // Find all TabControls on the form
            foreach (var tab in form.Controls.OfType<TabControl>())
            {
                // Find all TabPages in this TabControl
                foreach (var page in tab.Controls.OfType<TabPage>())
                {
                    // Find all TabControls in the TabPage
                    foreach (var tabTwo in page.Controls.OfType<TabControl>())
                    {
                        // Find all TabPages inside this TabControl
                        foreach (var pageTwo in tabTwo.Controls.OfType<TabPage>())
                        {
                            // Find all GroupBoxes in this tab
                            foreach (var gb in pageTwo.Controls.OfType<GroupBox>())
                            {
                                // Is this the GroupBox that contains parameter button?
                                if (gb.Contains(button))
                                {
                                    // Change all of the buttons in this GroupBox
                                    foreach (var b in gb.Controls.OfType<Button>())
                                    {
                                        b.BackColor = form.colRed;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Highlight the selected button
            button.BackColor = form.colDarkBlue;
        }

        public static void ButtonOnOff(FormMain form, Button button)
        {
            if (button.BackColor == form.colRed)
            {
                button.BackColor = form.colDarkBlue;
            } 
            else
	        {
                button.BackColor = form.colRed;
	        }
        }

        public static void ButtonEnterEffect(FormMain form, Button button)
        {
            button.ForeColor = form.colMedLightBlue;
        }

        public static void ButtonLeaveEffect(FormMain form, Button button)
        {
            button.ForeColor = form.colFormBackColor;
        }
    }
}
