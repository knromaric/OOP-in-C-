using System.Collections.Generic;

namespace WorkFlow_Engine
{
    public class Workflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow(IList<IActivity> activities)
        {
            _activities = activities;
        }

        public IList<IActivity> GetActivaties()
        {
            return _activities;
        }

    }
}
