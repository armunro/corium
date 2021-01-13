using System.Collections.Generic;
using Corium.Domain;
using Corium.Domain.Client.Window;
using Corium.Domain.Toolset;

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
                    Windows = new List<ToolView>()
                    {
                        new ToolView()
                        {
                            Name = "Month",
                            StartUrl = "https://calendar.google.com/calendar/u/0/r",
                            WindowAppearanceState = new ClientWindowAppearanceState()
                            {
                                Title = "GCAL | Month",
                                TitleBarBackground = "Black", 
                                TitleBarIconColor = "White",
                                WindowBorderColor = "Black"
                            }
                        },
                        new ToolView()
                        {
                            Name = "Agenda",
                            StartUrl = "https://calendar.google.com/calendar/u/0/r/day",
                            WindowAppearanceState = new ClientWindowAppearanceState()
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