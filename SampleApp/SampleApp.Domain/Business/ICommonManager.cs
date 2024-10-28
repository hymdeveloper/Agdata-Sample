using SampleApp.Domain.DTOs;

namespace SampleApp.Domain.Business
{
    public interface ICommonManager
    {
        /// <summary>
        /// The method which add the person data to DB (currentluy mocked)
        /// </summary>
        /// <param name="person"></param>
        /// <returns>The name and address of the person</returns>
        PersonDto AddData(PersonDto person);
    }
}
