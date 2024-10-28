using SampleApp.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Domain.Business.Services
{
    public class CommonManager : ICommonManager
    {
        /// <summary>
        /// The method which add the person data to DB (currentluy mocked)
        /// </summary>
        /// <param name="person"></param>
        /// <returns>The name and address of the person</returns>
        public PersonDto AddData(PersonDto person)
        {
            //Return the data which is incoming
            PersonDto personDto = new PersonDto();
            personDto.Name = person.Name;
            personDto.Address = person.Address;

            //This method can be used in future to lead to a db logic

            return personDto;
        }
    }
}
