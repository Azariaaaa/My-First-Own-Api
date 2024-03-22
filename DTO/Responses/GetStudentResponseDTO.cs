using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOwnApi.DTO.Responses
{
    public class GetStudentResponseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Training Training { get; set; }
        public float Average { get; set; }
    }
}
