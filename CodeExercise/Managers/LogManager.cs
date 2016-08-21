using CodeExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeExercise.Managers
{
    public class LogManager: ILogManager
    {

        public void LogAuthorization(LinkedinUser user)
        {
            //logic to log authorization would be here

            /*
             * I prefer to keep code simple. I've seen architectures, where a manager would connect to a repository,
             * which would then access the data. In many of those cases some levels were fluff and clutter.
             * I say all that just to say that for this code example, I would probably connect to the DbContext from the manager.
             * 
             * The DbContext (and related classes) would also 
             */
        }
    }
}