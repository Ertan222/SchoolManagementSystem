using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models.İnterfaces
{
    public interface IHuman
    {
        int HumanId { get; set; }
        string FirstandSecondName { get; set; }
        string Lastname { get; set; }
        int GenderId { get; set; }
        DateTime DOB { get; set; }
        string Address { get; set; }


    }
}
