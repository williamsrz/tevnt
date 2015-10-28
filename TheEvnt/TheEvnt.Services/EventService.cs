using System;
using System.Threading.Tasks;
using TheEvnt.Models;

namespace TheEvnt.Services
{
    public class EventService : IEventService
    {
        //TODO: Turn to live services
        private Event _event;

        public EventService()
        {
            
        }

        #region IEventService implementation

        public async Task<Event> GetEventAsync()
        {
            return await Task.Factory.StartNew(() =>
                _event = new Event
                {
                    Id = "1",
                    Name = "GDG Fest Sul 2015",
                    Description = "Vem aí a edição SUL do DevFest, a maior conferência brasileira sobre tecnologias Google, organizado pela comunidade de desenvolvedores Google!",
                    City = "Curitiba",
                    State = "Paraná",
                    Day = new DateTime(2015, 11, 14, 0, 0, 0),
                    CoverImageUrl = "http://devfestsul.com.br/images/logo.png",
                    RegistrationUrl = "http://www.eventbrite.com.br/e/gdg-devfest-sul-2015-registration-19058779322",
                    FullAddress = "Encontro da Amazônia, Rua Nilo Pecanha 1907, Matriz",
                }
            );
        }

        #endregion
    }
}

