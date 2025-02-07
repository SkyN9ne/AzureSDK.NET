// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.EventHubs;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHubs.Samples
{
    public partial class Sample_EventHubsClusterResource
    {
        // ListAvailableClusters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableClusterRegionClusters_ListAvailableClusters()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/preview/2022-01-01-preview/examples/Clusters/ListAvailableClustersGet.json
            // this example is just showing the usage of "Clusters_ListAvailableClusterRegion" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (AvailableCluster item in subscriptionResource.GetAvailableClusterRegionClustersAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ClustersListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEventHubsClusters_ClustersListBySubscription()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/preview/2022-01-01-preview/examples/Clusters/ClustersListBySubscription.json
            // this example is just showing the usage of "Clusters_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (EventHubsClusterResource item in subscriptionResource.GetEventHubsClustersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventHubsClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ClusterGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ClusterGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/preview/2022-01-01-preview/examples/Clusters/ClusterGet.json
            // this example is just showing the usage of "Clusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsClusterResource created on azure
            // for more information of creating EventHubsClusterResource, please refer to the document of EventHubsClusterResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "myResourceGroup";
            string clusterName = "testCluster";
            ResourceIdentifier eventHubsClusterResourceId = EventHubsClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            EventHubsClusterResource eventHubsCluster = client.GetEventHubsClusterResource(eventHubsClusterResourceId);

            // invoke the operation
            EventHubsClusterResource result = await eventHubsCluster.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ClusterPatch
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ClusterPatch()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/preview/2022-01-01-preview/examples/Clusters/ClusterPatch.json
            // this example is just showing the usage of "Clusters_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsClusterResource created on azure
            // for more information of creating EventHubsClusterResource, please refer to the document of EventHubsClusterResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "myResourceGroup";
            string clusterName = "testCluster";
            ResourceIdentifier eventHubsClusterResourceId = EventHubsClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            EventHubsClusterResource eventHubsCluster = client.GetEventHubsClusterResource(eventHubsClusterResourceId);

            // invoke the operation
            EventHubsClusterData data = new EventHubsClusterData(new AzureLocation("South Central US"))
            {
                Tags =
{
["tag3"] = "value3",
["tag4"] = "value4",
},
            };
            ArmOperation<EventHubsClusterResource> lro = await eventHubsCluster.UpdateAsync(WaitUntil.Completed, data);
            EventHubsClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ClusterDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ClusterDelete()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/preview/2022-01-01-preview/examples/Clusters/ClusterDelete.json
            // this example is just showing the usage of "Clusters_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsClusterResource created on azure
            // for more information of creating EventHubsClusterResource, please refer to the document of EventHubsClusterResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "myResourceGroup";
            string clusterName = "testCluster";
            ResourceIdentifier eventHubsClusterResourceId = EventHubsClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            EventHubsClusterResource eventHubsCluster = client.GetEventHubsClusterResource(eventHubsClusterResourceId);

            // invoke the operation
            await eventHubsCluster.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ListNamespacesInCluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNamespaces_ListNamespacesInCluster()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/preview/2022-01-01-preview/examples/Clusters/ListNamespacesInClusterGet.json
            // this example is just showing the usage of "Clusters_ListNamespaces" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsClusterResource created on azure
            // for more information of creating EventHubsClusterResource, please refer to the document of EventHubsClusterResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "myResourceGroup";
            string clusterName = "testCluster";
            ResourceIdentifier eventHubsClusterResourceId = EventHubsClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            EventHubsClusterResource eventHubsCluster = client.GetEventHubsClusterResource(eventHubsClusterResourceId);

            // invoke the operation and iterate over the result
            await foreach (SubResource item in eventHubsCluster.GetNamespacesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ClustersQuotasConfigurationPatch
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PatchConfiguration_ClustersQuotasConfigurationPatch()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/preview/2022-01-01-preview/examples/Clusters/ClusterQuotaConfigurationPatch.json
            // this example is just showing the usage of "Configuration_Patch" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsClusterResource created on azure
            // for more information of creating EventHubsClusterResource, please refer to the document of EventHubsClusterResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string clusterName = "testCluster";
            ResourceIdentifier eventHubsClusterResourceId = EventHubsClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            EventHubsClusterResource eventHubsCluster = client.GetEventHubsClusterResource(eventHubsClusterResourceId);

            // invoke the operation
            ClusterQuotaConfigurationProperties clusterQuotaConfigurationProperties = new ClusterQuotaConfigurationProperties()
            {
                Settings =
{
["eventhub-per-namespace-quota"] = "20",
["namespaces-per-cluster-quota"] = "200",
},
            };
            ClusterQuotaConfigurationProperties result = await eventHubsCluster.PatchConfigurationAsync(clusterQuotaConfigurationProperties);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ClustersQuotasConfigurationGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetConfiguration_ClustersQuotasConfigurationGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/preview/2022-01-01-preview/examples/Clusters/ClusterQuotaConfigurationGet.json
            // this example is just showing the usage of "Configuration_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsClusterResource created on azure
            // for more information of creating EventHubsClusterResource, please refer to the document of EventHubsClusterResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "myResourceGroup";
            string clusterName = "testCluster";
            ResourceIdentifier eventHubsClusterResourceId = EventHubsClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            EventHubsClusterResource eventHubsCluster = client.GetEventHubsClusterResource(eventHubsClusterResourceId);

            // invoke the operation
            ClusterQuotaConfigurationProperties result = await eventHubsCluster.GetConfigurationAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
