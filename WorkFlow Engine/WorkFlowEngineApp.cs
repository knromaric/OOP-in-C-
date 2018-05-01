using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow_Engine
{
    class WorkFlowEngineApp
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            var video = new VideoActivity();
            var mail = new EmailActivity();
            var listOfActivities = new List<IActivity>()
            {
                video,
                mail
            };

            var workflow = new Workflow(listOfActivities);

            workflowEngine.Run(workflow);


            
        }
    }
}
