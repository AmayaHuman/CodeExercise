using CodeExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise.Managers
{
    public interface ILogManager
    {
        void LogAuthorization(LinkedinUser user);
    }
}
