﻿//-------------------------------------------------------------------------------
// <copyright file="EvaluationEngineTest.cs" company="Appccelerate">
//   Copyright (c) 2008-2014
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Net45
{
    using System.Reflection;
    using Appccelerate.EvaluationEngine;
    using Appccelerate.EvaluationEngine.Expressions;

    public class EvaluationEngineTest
    {
        public void Run()
        {
            var engine = new EvaluationEngine();

            engine
                .Solve<MyQuestion, string>()
                    .AggregateWithExpressionAggregator(string.Empty, (a, b) => a + " " + b)
                    .ByEvaluating((q, p) => "first")
                    .ByEvaluating(q => new MyExpression());
        }

        public class MyQuestion : Question<string>
        {
        }

        public class MyExpression : IExpression<string>
        {
            public string Describe()
            {
                return "useful description";
            }

            public string Evaluate(Missing parameter)
            {
                return "second";
            }
        }
    }
}