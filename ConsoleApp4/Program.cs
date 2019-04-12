using org.apache.rocketmq.client.consumer;
using org.apache.rocketmq.common.consumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string topic = "topicF";
                DefaultMQPushConsumer _consumer = new DefaultMQPushConsumer("prod900900");
                _consumer.setNamesrvAddr("localhost:9876");
               // _consumer.setVipChannelEnabled(false);
                _consumer.setConsumeFromWhere(ConsumeFromWhere.CONSUME_FROM_FIRST_OFFSET);
                _consumer.subscribe(topic, "*");

                RoutingListener listener = new RoutingListener();
                _consumer.registerMessageListener(listener);
                _consumer.start();

                //_consumer.createTopic("TBW102", topic, 4);

               // Console.ReadKey();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
