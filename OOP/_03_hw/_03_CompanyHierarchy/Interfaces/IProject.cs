﻿using System;

namespace _03_CompanyHierarchy.Interfaces
{
    using Enumerations;
    interface IProject
    {
        string Name { get; set; }

        DateTime StartDate { get; set; }

        string Details { get; set; }

        State State { get; set; }

        void CloseProject();
    }
}