using System;
using SIMS.Model;

namespace SIMS.Controller
{
    public interface IExitController
    {
        void Add(Exit exit);
        void Save();
        bool IsSpeedExceeded(TimeSpan time, Exit exit);
    }
}