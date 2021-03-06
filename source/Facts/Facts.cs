﻿//-------------------------------------------------------------------------------
// <copyright file="Facts.cs" company="Appccelerate">
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

namespace Facts
{
    using Xunit;

    public class Facts
    {
        [Fact]
        public void EvaluationEngine()
        {
            new Net45.EvaluationEngineTest().Run();
            new Portable.EvaluationEngineTest().Run();
        }

        [Fact]
        public void EventBroker()
        {
            new Net45.EventBrokerTest().Run();
        }

        [Fact]
        public void IO()
        {
            new Net45.IOTest().Run();
        }

        [Fact]
        public void StateMachine()
        {
            new Net45.StateMachineTest().Run();
            new Portable.StateMachineTest().Run();
        }

        [Fact]
        public void Bootstrapper()
        {
            new Net45.BootstrapperTest().Run();
        }

        [Fact]
        public void Fundamentals()
        {
            new Net45.FundamentalsTest().Run();
            new Portable.FundamentalsTest().Run();
        }
    }
}