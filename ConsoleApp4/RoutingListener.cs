using java.util;
using org.apache.rocketmq.client.consumer.listener;
using org.apache.rocketmq.common.message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class RoutingListener : MessageListenerConcurrently
    {
        public RoutingListener()
        {
        }


        //public ConsumeConcurrentlyStatus consumeMessage(List<MessageExt> msgs,
        //        ConsumeConcurrentlyContext context)
        //{
        //    Console.WriteLine("%s Receive New Messages: %s %n", msgs);
        //    return ConsumeConcurrentlyStatus.CONSUME_SUCCESS;
        //}

        public ConsumeConcurrentlyStatus consumeMessage(List msgs, ConsumeConcurrentlyContext context)

        {
            try

            {
                var messageList = msgs.iterator();
                while (messageList.hasNext())
                {
                    MessageExt msg = (MessageExt)messageList.next();
                    byte[] msgbody = msg.getBody();
                    string body = Encoding.UTF8.GetString(msgbody);
                    Console.WriteLine("===> consumed msg :" + body);
                }
            }
            catch (Exception ex)
            {
            }

            return ConsumeConcurrentlyStatus.CONSUME_SUCCESS;
        }
        //public ConsumeOrderlyStatus consumeMessage(List msgs, ConsumeOrderlyContext context)
        //{
        //    try

        //    {
        //        var messageList = msgs.iterator();
        //        while (messageList.hasNext())
        //        {
        //            MessageExt msg = (MessageExt)messageList.next();
        //            byte[] msgbody = msg.getBody();
        //            string body = Encoding.UTF8.GetString(msgbody);
        //            Console.WriteLine("===> consumed msg :" + body);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return ConsumeOrderlyStatus.SUCCESS;
        //}
    }
}
