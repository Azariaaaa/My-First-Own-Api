using FastEndpoints;
using MyFirstOwnApi.DTO.Requests;
using MyFirstOwnApi.DTO.Responses;
using MyFirstOwnApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOwnApi.EndPoints
{
    public class GetStudentEndPoint : Endpoint<GetStudentRequestDTO, GetStudentResponseDTO>
    {
        public override void Configure()
        {
            Get("/Get");
            AllowAnonymous();
        }
        public override Task HandleAsync(GetStudentRequestDTO req, CancellationToken ct)
        {
            Console.WriteLine("Récupération des informations du user ayant l'id : " + req.Id );
            var getStudent = Student.GetStudentById(req.Id);

            var response = new GetStudentResponseDTO
            {
                Name = getStudent.Name,
                FirstName = getStudent.FirstName,
                Age = getStudent.Age,
                Training = getStudent.Training,
                Average = getStudent.Average
            };

            return SendAsync(response);
        }
    }
}
