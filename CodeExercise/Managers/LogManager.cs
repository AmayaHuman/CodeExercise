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
            //I would also consider loosely coupling the user parameter. 

            /*
             * I prefer to keep code simple. I've seen architectures, where a the code drills down a bunch of levels 
             * in order to access the data. Some levels were fluff and clutter, just passing values through.
             * I say all that just to say that for this code example, I would probably connect to the DbContext from the LogManager.
             * 
             * I would probably have the LogManager in a separate project to 
             * (no references from view project to the data access layer.) 
             */
        }
    }
}