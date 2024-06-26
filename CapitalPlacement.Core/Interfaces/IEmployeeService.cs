﻿using CapitalPlacement.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Core.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<DisplayCustomQuestionsCandidate>> GetAllQuestions();
        Task<DisplayCustomQuestionsCandidate> GetQuestion(string id);
        Task<DisplayCustomQuestionDTO> AnswerQuestion(AnswerQuestionDTO model);
    }
}
