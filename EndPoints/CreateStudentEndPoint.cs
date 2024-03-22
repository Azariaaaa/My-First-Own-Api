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
    public class CreateStudentEndPoint : Endpoint<CreateStudentRequestDTO, CreateStudentResponseDTO>
    {
        public override void Configure()
        {
            Post("/Create");
            AllowAnonymous();
        }

        public override Task HandleAsync(CreateStudentRequestDTO req, CancellationToken ct)
        {
            Console.WriteLine("Création de l'étudiant");

            var createStudent = Student.CreateStudent(req.Name, req.FirstName, req.Age, req.Training, req.Average);

            var response = new CreateStudentResponseDTO
            {
                Id = createStudent.Id,
                Name = createStudent.Name,
                FirstName = createStudent.FirstName,
                Age = createStudent.Age,
                Training = createStudent.Training,
                Average = createStudent.Average
            };

            return SendAsync(response);
        }
    }
}
