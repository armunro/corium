using System.Collections.Generic;
using Corium.Domain;

namespace Corium.Examples.Toolset
{
    public class ExampleBasicGoogleToolset
    {
        public static ToolSet ProvideToolset => new ToolSet()
        {
            Name = "Google Tools",
            Tools = new List<Tool>()
            {
                new Tool()
                {
                    Name = "Google Calendar",
                    Windows = new List<ToolWindow>()
                    {
                        new ToolWindow()
                        {
                            Name = "Month",
                            StartUrl = "https://calendar.google.com/calendar/u/0/r",
                            Appearance = new ToolWindowAppearance()
                            {
                                Title = "GCAL | Month",
                                TitleBarBackground = "Black", 
                                TitleBarIconColor = "White",
                                WindowBorderColor = "Black"
                            }
                        },
                        new ToolWindow()
                        {
                            Name = "Adgenda",
                            StartUrl = "https://calendar.google.com/calendar/u/0/r/day",
                            Appearance = new ToolWindowAppearance()
                            {
                                Title = "GCAL | Agenda",
                                TitleBarBackground = "Green", 
                                TitleBarIconColor = "White",
                                WindowBorderColor = "Green"
                            }
                        }
                    }
                }
            }
        };
    }
}