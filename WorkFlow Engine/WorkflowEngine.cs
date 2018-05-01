using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow_Engine
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)  
        {
            foreach (var activity in workflow.GetActivaties())
            {
                activity.Execute();
            }
        }
    }
}
