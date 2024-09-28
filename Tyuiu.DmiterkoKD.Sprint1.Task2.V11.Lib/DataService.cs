using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DmiterkoKD.Sprint1.Task2.V11.Lib
{
    public class DataService : ISprint1Task2V11
    {
        public int ConvertHoursMinutesToSeconds(int chas, int min)
        {
            return chas * 3600 + min * 60; 
        }
    }
}
