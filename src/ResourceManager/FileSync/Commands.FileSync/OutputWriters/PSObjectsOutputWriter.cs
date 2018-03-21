﻿using System.Management.Automation;
using AFSEvaluationTool.Validations;

namespace AFSEvaluationTool.OutputWriters
{
    public class PsObjectsOutputWriter : IOutputWriter
    {
        private readonly ICmdlet _cmdlet;

        public PsObjectsOutputWriter(ICmdlet cmdlet)
        {
            _cmdlet = cmdlet;
        }

        public void Write(IValidationResult validationResult)
        {
            if (validationResult.Result != Result.Success)
            {
                _cmdlet.WriteObject(validationResult);
            }
            
        }
    }
}