using System.Collections.Generic;
using Corium.Domain;
using Corium.Domain.Toolset;
using Corium.Domain.Window.State;

namespace Corium.Application.Example.Toolset
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
                    Windows = new List<WindowState>()
                    {
                        new WindowState()
                        {
                            StartUrl = "https://calendar.google.com/calendar/u/0/r",
                            Appearance = new WindowAppearanceState()
                            {
                                Title = "GCAL | Month",
                                TitleBarBackground = "Black",
                                TitleBarIconColor = "White",
                                WindowBorderColor = "Black"
                            }
                        },
                        new WindowState()
                        {
                            StartUrl = "https://calendar.google.com/calendar/u/0/r/day",
                            Appearance = new WindowAppearanceState()
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