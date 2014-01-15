//-------------------------------------------------------------------------------
// <copyright file="StateMachineTest.cs" company="Appccelerate">
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

namespace Portable
{
    using Appccelerate.StateMachine;

    public class StateMachineTest
    {
         public void Run()
         {
             var machine = new PassiveStateMachine<int, int>();

             machine.In(1)
                 .On(2).Goto(2);

             machine.Initialize(1);
             machine.Start();

             machine.Fire(2);
         }
    }
}