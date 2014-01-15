//-------------------------------------------------------------------------------
// <copyright file="EventBrokerTest.cs" company="Appccelerate">
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
    using System;
    using Appccelerate.EventBroker;
    using Appccelerate.EventBroker.Handlers;

    public class EventBrokerTest
    {
        public void Run()
        {
            var eventBroker = new EventBroker();

            var publisher = new Publisher();
            var subscriber = new Subscriber();

            eventBroker.Register(publisher);
            eventBroker.Register(subscriber);

            publisher.FireEvent();
        }

        public class Publisher
        {
            [EventPublication("topic")]
            public event EventHandler Event;

            public void FireEvent()
            {
                this.Event(this, EventArgs.Empty);
            }
        }

        public class Subscriber
        {
            [EventSubscription("topic", typeof(OnPublisher))]
            public void HandleEvent()
            {
            }
        }
    }
}