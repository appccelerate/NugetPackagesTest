//-------------------------------------------------------------------------------
// <copyright file="BootstrapperTest.cs" company="Appccelerate">
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
    using Appccelerate.Bootstrapper;
    using Appccelerate.Bootstrapper.Syntax;

    public class BootstrapperTest
    {
        public void Run()
        {
            var strategy = new MyStrategy();
            var myExtension = new MyExtension();

            using (var bootstrapper = new DefaultBootstrapper<IMyExtension>())
            {
                bootstrapper.Initialize(strategy);

                bootstrapper.AddExtension(myExtension);

                bootstrapper.Run();

                bootstrapper.Shutdown();
            }
        }

        public interface IMyExtension : IExtension
        {
            void Foo();

            void Bar();
        }

        public class MyExtension : IMyExtension
        {
            public string Describe()
            {
                return "description";
            }

            public string Name
            {
                get { return "my name"; }
            }

            public void Foo()
            {
            }

            public void Bar()
            {
            }
        }

        public class MyStrategy : AbstractStrategy<IMyExtension>
        {
            protected override void DefineRunSyntax(ISyntaxBuilder<IMyExtension> builder)
            {
                builder
                    .Execute(extension => extension.Foo());
            }

            protected override void DefineShutdownSyntax(ISyntaxBuilder<IMyExtension> builder)
            {
                builder
                    .Execute(extension => extension.Bar());
            }
        }
    }
}