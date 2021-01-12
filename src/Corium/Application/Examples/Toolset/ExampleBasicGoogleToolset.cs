using System.Collections.Generic;
using Corium.Domain;
using Corium.Domain.View;

namespace Corium.Application.Examples.Toolset
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
                            Appearance = new ClientAppearance()
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
                            Appearance = new ClientAppearance()
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