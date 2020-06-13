using System;

namespace KafkaClient.src.Client.Configuration
{
    public class ProducerConfigurationManager
    {
        /// <summary>
        /// Controls how many partition replicas must receive the record.
        /// </summary>
        public int Acks;

        /// <summary>
        /// The amount of memory used by the producer to buffer messages.
        /// </summary>
        public int BufferMemory;

        /// <summary>
        /// Specifies the client id which will be used by brokers for telemetry.
        /// </summary>
        public string ClientId;

        /// <summary>
        /// Amount of time in milliseconds the procuder will wait for
        /// new messages before sending the current batch.
        /// </summary>
        ///
        public int LingerMs;

        /// <summary>
        /// The maximum amount of time a producer will block when sending
        /// messages or requesting metadata from the server.
        /// </summary>
        public int MaxBlockMs;

        /// <summary>
        /// Number of messages a producer will send without receiving a
        /// response.
        /// </summary>
        public int MaxRequestsPerConnection;

        /// <summary>
        /// Maximum amount of bytes that can be sent to the broker in a batch.
        /// </summary>
        public int MaxRequestBytes;

        /// <summary>
        /// Amount of time in milliseconds the producer will wait for a
        /// server metadata response.
        /// </summary>
        public int MetadataTimeoutMs;

        /// <summary>
        /// Size of the TCP send buffer used by a socket. If this is set to -1,
        /// the default OS buffer size is used.
        /// </summary>
        public int ReceiveBufferBytes;

        /// <summary>
        /// Amount of time in milliseconds the producer will wait for a server
        /// response after sending messages.
        /// </summary>
        public int RequestTimeoutMs;

        /// <summary>
        /// Number of times a producer will retry sending a message.
        /// </summary>
        public int Retries;

        /// <summary>
        /// Size of the TCP receive buffer used by a socket. If this is set to
        /// -1, the default OS buffer size is used.
        /// </summary>
        public int SendBufferBytes;

        /// <summary>
        /// Amount of time in milliseconds the broker will wait for in-sync
        /// replicas to acknowledge incoming messages to satisfy the acks
        /// parameter.
        /// </summary>
        public int TimeoutMs;

        public ProducerConfigurationManager()
        {
            this.Acks = 0;
            this.BufferMemory = 1024 * 1024;
            this.ClientId = null;
            this.LingerMs = 100;
            this.MaxBlockMs = 500;
            this.MaxRequestsPerConnection = 1;
            this.MaxRequestBytes = 1024 * 1024;
            this.MetadataTimeoutMs = 1000;
            this.ReceiveBufferBytes = -1;
            this.RequestTimeoutMs = 1000;
            this.Retries = 0;
            this.SendBufferBytes = -1;
            this.TimeoutMs = 1000;
        }
    }
}
