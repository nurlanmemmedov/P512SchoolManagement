using AutoMapper;
using Data.DAL;
using Data.Services;
using Domain.Dtos;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryService<Student> _repo;

        public StudentsController(IMapper mapper, IRepositoryService<Student> repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            List<Student> students = await _repo.GetAll();
            List<Student> studentsa = await _repo.GetAll();

            List<StudentDto> studentDtos = _mapper.Map<List<StudentDto>>(students);

            return Ok(studentDtos);
        }

    }
}
