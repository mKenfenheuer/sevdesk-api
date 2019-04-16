using System;
using System.Collections.Generic;
using RestSharp;
using SevDeskApi.Client;
using SevDeskApi.Model;

namespace SevDeskApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IContactApi
    {
        /// <summary>
        /// Add an address Adds an address to the contact by calling addAddress() in Contact.php. Address is defined in ContactAddress.php
        /// </summary>
        /// <param name="id">Id of contact you want to add an address to</param>
        /// <param name="body">Change the desired values and remove the quotation marks to add an address.</param>
        /// <returns>ModelContactAddress</returns>
        ModelContactAddress AddAddress (int? id, string body);
        /// <summary>
        /// Create a new contact of type person or company Creating a new contact of type person/company calls a shared path with the same http-verb.  However, both types require certain parameters which will indicate that their type of contact should be created.  So, using **familyname** or **name** in front of &#39;category&#39; will define if either a person or a company is created
        /// </summary>
        /// <param name="body">Concatenate the following attributes with &#39;&amp;&#39; to the example and put **familyname&#x3D;yourFamilyName&amp;** at the beginning to define the **person** you want to add and remove the quotation marks:  * customerNumber  * gender (m,w, empty)  * academicTitle, titel  * surename, name2  * bankNumber, bankAccount, vatNumber  * defaultCashbackTime, defaultCashbackPercent, defaultTimeToPay  * description    Concatenate the following attributes with &#39;&amp;&#39; to the example and put **name&#x3D;yourCompanyName&amp;** at the beginning  to define the **company** you want to add and remove the quotation marks:  * name2  * bankNumber, bankAccount, vatNumber  * defaultCashbackTime, defaultCashbackPercent, defaultTimeToPay  * description</param>
        /// <returns>ModelContact</returns>
        ModelContact AddContact (string body);
        /// <summary>
        /// Create a new communication way for a contact Calls addCommunicationWay() in Contact.php
        /// </summary>
        /// <param name="id">Id of contact you want to add a communication way to</param>
        /// <param name="value">Value of the communication way you want to add</param>
        /// <param name="key">Key of the communication way you want to add</param>
        /// <param name="type">Type of communication way you want to add</param>
        /// <returns>ModelCommunicationWay</returns>
        ModelCommunicationWay AddContactCommunicationWay (int? id, string value, int? key, string type);
        /// <summary>
        /// Add a new mobile number Calls addMobile in Contact.php
        /// </summary>
        /// <param name="id">Id of contact you want to update</param>
        /// <param name="body">Change the desired values and remove the quotation marks to add a mobile number.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address)</param>
        /// <returns></returns>
        void AddMobile (int? id, string body);
        /// <summary>
        /// Add a new phone number Calls addPhone() in Contact.php
        /// </summary>
        /// <param name="id">Id of contact you want to update</param>
        /// <param name="body">Change the desired values and remove the quotation marks to add a phone number.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address)</param>
        /// <returns></returns>
        void AddPhone (int? id, string body);
        /// <summary>
        /// Add a new website Calls addWeb() in Contact.php
        /// </summary>
        /// <param name="id">Id of contact you want to update</param>
        /// <param name="body">Change the desired values and remove the quotation marks to add a website.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address)</param>
        /// <returns></returns>
        void AddWebsite (int? id, string body);
        /// <summary>
        /// Add a new email Calls addEmail() in Contact.php
        /// </summary>
        /// <param name="id">Id of contact you want to update</param>
        /// <param name="body">Change the desired values and remove the quotation marks to add an email.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address)</param>
        /// <returns></returns>
        void ContactAddEmail (int? id, string body);
        /// <summary>
        /// Create a new contact of type person or company With the new version of sevdesk some models are not created by calling the model.php directly but by calling the factory.php because of better performance and flexibility.    Basically the model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new invoice it wont be saved by a POST request with &#39;/Invoice?para1&#x3D;&amp;...&#39; but with the saveInvoice function in Factory.php &#39;Voucher/Factory/saveInvoice?para1&#x3D;&#39;    Creating a new contact of type person/company calls a shared path with the same http-verb.    However, both types require certain parameters which will indicate that their type of contact should be created.    So, using **familyname** or **name** in front of &#39;category&#39; will define if either a person or a company is created
        /// </summary>
        /// <param name="body">Concatenate the following attributes with &#39;&amp;&#39; to the example and put **data[familyname]&#x3D;yourFamilyName&amp;** at the beginning to define the **person** you want to add and remove the quotation marks:  * &amp;data[customerNumber]&#x3D;  * &amp;data[gender]&#x3D; (m,w, empty)  * &amp;data[academicTitle]&#x3D;, &amp;data[titel]&#x3D;  * &amp;data[surename]&#x3D;, &amp;data[name2]&#x3D;  * &amp;data[bankNumber]&#x3D;, &amp;data[bankAccount]&#x3D;, &amp;data[vatNumber]&#x3D;  * &amp;data[defaultCashbackTime]&#x3D;, &amp;data[defaultCashbackPercent]&#x3D;, &amp;data[defaultTimeToPay]&#x3D;  * &amp;data[description]&#x3D;    Concatenate the following attributes with &#39;&amp;&#39; to the example and put **data[name]&#x3D;yourCompanyName&amp;** at the beginning  to define the **company** you want to add and remove the quotation marks:  * &amp;data[name2]&#x3D;  * &amp;data[bankNumber]&#x3D;, &amp;data[bankAccount]&#x3D;, &amp;data[vatNumber]&#x3D;  * &amp;data[defaultCashbackTime]&#x3D;, &amp;data[defaultCashbackPercent]&#x3D;, &amp;data[defaultTimeToPay]&#x3D;  * &amp;data[description]&#x3D;</param>
        /// <returns>ModelContact</returns>
        ModelContact ContactFactoryCreateContact (string body);
        /// <summary>
        /// Get the addresses of a specified contact Calls getAddresses() in Contact.php to get the addresses of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the addresses from</param>
        /// <param name="categoryId">Category of addresses you want to get</param>
        /// <param name="categoryObjectName"></param>
        /// <returns>ModelContactAddress</returns>
        ModelContactAddress ContactGetAddresses (int? id, int? categoryId, string categoryObjectName);
        /// <summary>
        /// Delete an existing contact Calls the delete() function in Contact.php
        /// </summary>
        /// <param name="id">id of contact you want to delete</param>
        /// <returns></returns>
        void DeleteContact (int? id);
        /// <summary>
        /// Get the billing address of a specified contact Calls getBillingAddress() in Contact.php to get the billing address of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the billing address from</param>
        /// <returns>ModelContactAddress</returns>
        ModelContactAddress GetContactBillingAddress (int? id);
        /// <summary>
        /// Get the billing email of a specified contact Calls getBillingEmail() in Contact.php to get the billing email of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the billing email from</param>
        /// <returns>ModelCommunicationWay</returns>
        ModelCommunicationWay GetContactBillingEmail (int? id);
        /// <summary>
        /// Get the communication ways of a specified contact Calls getCommunicationWays() in Contact.php to get the communication ways of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the communication ways from</param>
        /// <param name="type">Type of communication ways you want to get</param>
        /// <returns>ModelCommunicationWay</returns>
        ModelCommunicationWay GetContactCommunicationWays (int? id, string type);
        /// <summary>
        /// Get the main address of a specified contact Calls getMainAddress() in Contact.php to get the main address of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the main address from</param>
        /// <returns>ModelContactAddress</returns>
        ModelContactAddress GetContactMainAddress (int? id);
        /// <summary>
        /// Get the main email of a specified contact Calls getMainEmail() in Contact.php to get the main email of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the main email from</param>
        /// <returns>ModelCommunicationWay</returns>
        ModelCommunicationWay GetContactMainEmail (int? id);
        /// <summary>
        /// Get the main mobile of a specified contact Calls getMainMobile() in Contact.php to get the main mobile of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the main mobile from</param>
        /// <returns>ModelCommunicationWay</returns>
        ModelCommunicationWay GetContactMainMobile (int? id);
        /// <summary>
        /// Get the main phone of a specified contact Calls getMainPhone() in Contact.php to get the main phone of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the main phone from</param>
        /// <returns>ModelCommunicationWay</returns>
        ModelCommunicationWay GetContactMainPhone (int? id);
        /// <summary>
        /// Get the main website of a specified contact Calls getMainWebsite() in Contact.php to get the main website of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the main website from</param>
        /// <returns>ModelCommunicationWay</returns>
        ModelCommunicationWay GetContactMainWebsite (int? id);
        /// <summary>
        /// Get the related communication ways of a specified contact Calls getRelatedCommunicationWays() in Contact.php to get the related communication ways of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the related communication ways from</param>
        /// <param name="type">Type of related communication ways you want to get</param>
        /// <returns>ModelCommunicationWay</returns>
        ModelCommunicationWay GetContactRelatedCommunicationWays (int? id, string type);
        /// <summary>
        /// Get number of all invoices, orders, etc. of a specified contact Calls getTabsItemCount() in Contact.php to get the number of all invoices, orders, etc. of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the number of all invoices, orders, etc. from</param>
        /// <returns></returns>
        void GetContactTabsItemCount (int? id);
        /// <summary>
        /// Get an overview of all contacts Calls Contact.php to get necessary variables
        /// </summary>
        /// <param name="depth">If depth is set 1 companies and persons will be shown, otherwise only the companies will be shown. Default: 0</param>
        /// <param name="limit">Limits the number of entries returned. Default is 100</param>
        /// <param name="offset">Set the index where the returned contacts start. Default is 0</param>
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param>
        /// <returns>ModelContact</returns>
        ModelContact GetContacts (int? depth, int? limit, int? offset, List<string> embed);
        /// <summary>
        /// Get the next customer number Get the next customer number in the sequence
        /// </summary>
        /// <returns></returns>
        void GetNextCustomerNumber ();
        /// <summary>
        /// Update an existing contact Calls Contact.php to update an existing contact
        /// </summary>
        /// <param name="id">Id of contact you want to update</param>
        /// <param name="body">Parameters which need to be updated. Please be aware not to update any parameters which don&#39;t belong to the type of contact you are updating    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param>
        /// <returns>ModelContact</returns>
        ModelContact UpdateContact (int? id, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ContactApi : IContactApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ContactApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ContactApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Add an address Adds an address to the contact by calling addAddress() in Contact.php. Address is defined in ContactAddress.php
        /// </summary>
        /// <param name="id">Id of contact you want to add an address to</param> 
        /// <param name="body">Change the desired values and remove the quotation marks to add an address.</param> 
        /// <returns>ModelContactAddress</returns>            
        public ModelContactAddress AddAddress (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddAddress");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddAddress");
            
    
            var path = "/Contact/{id}/addAddress";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelContactAddress) ApiClient.Deserialize(response.Content, typeof(ModelContactAddress), response.Headers);
        }
    
        /// <summary>
        /// Create a new contact of type person or company Creating a new contact of type person/company calls a shared path with the same http-verb.  However, both types require certain parameters which will indicate that their type of contact should be created.  So, using **familyname** or **name** in front of &#39;category&#39; will define if either a person or a company is created
        /// </summary>
        /// <param name="body">Concatenate the following attributes with &#39;&amp;&#39; to the example and put **familyname&#x3D;yourFamilyName&amp;** at the beginning to define the **person** you want to add and remove the quotation marks:  * customerNumber  * gender (m,w, empty)  * academicTitle, titel  * surename, name2  * bankNumber, bankAccount, vatNumber  * defaultCashbackTime, defaultCashbackPercent, defaultTimeToPay  * description    Concatenate the following attributes with &#39;&amp;&#39; to the example and put **name&#x3D;yourCompanyName&amp;** at the beginning  to define the **company** you want to add and remove the quotation marks:  * name2  * bankNumber, bankAccount, vatNumber  * defaultCashbackTime, defaultCashbackPercent, defaultTimeToPay  * description</param> 
        /// <returns>ModelContact</returns>            
        public ModelContact AddContact (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddContact");
            
    
            var path = "/Contact";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddContact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddContact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelContact) ApiClient.Deserialize(response.Content, typeof(ModelContact), response.Headers);
        }
    
        /// <summary>
        /// Create a new communication way for a contact Calls addCommunicationWay() in Contact.php
        /// </summary>
        /// <param name="id">Id of contact you want to add a communication way to</param> 
        /// <param name="value">Value of the communication way you want to add</param> 
        /// <param name="key">Key of the communication way you want to add</param> 
        /// <param name="type">Type of communication way you want to add</param> 
        /// <returns>ModelCommunicationWay</returns>            
        public ModelCommunicationWay AddContactCommunicationWay (int? id, string value, int? key, string type)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddContactCommunicationWay");
            
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling AddContactCommunicationWay");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddContactCommunicationWay");
            
    
            var path = "/Contact/{id}/addCommunicationWay";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddContactCommunicationWay: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddContactCommunicationWay: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCommunicationWay) ApiClient.Deserialize(response.Content, typeof(ModelCommunicationWay), response.Headers);
        }
    
        /// <summary>
        /// Add a new mobile number Calls addMobile in Contact.php
        /// </summary>
        /// <param name="id">Id of contact you want to update</param> 
        /// <param name="body">Change the desired values and remove the quotation marks to add a mobile number.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address)</param> 
        /// <returns></returns>            
        public void AddMobile (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddMobile");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddMobile");
            
    
            var path = "/Contact/{id}/addMobile";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMobile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMobile: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add a new phone number Calls addPhone() in Contact.php
        /// </summary>
        /// <param name="id">Id of contact you want to update</param> 
        /// <param name="body">Change the desired values and remove the quotation marks to add a phone number.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address)</param> 
        /// <returns></returns>            
        public void AddPhone (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddPhone");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddPhone");
            
    
            var path = "/Contact/{id}/addPhone";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddPhone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddPhone: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add a new website Calls addWeb() in Contact.php
        /// </summary>
        /// <param name="id">Id of contact you want to update</param> 
        /// <param name="body">Change the desired values and remove the quotation marks to add a website.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address)</param> 
        /// <returns></returns>            
        public void AddWebsite (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AddWebsite");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddWebsite");
            
    
            var path = "/Contact/{id}/addWeb";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddWebsite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddWebsite: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add a new email Calls addEmail() in Contact.php
        /// </summary>
        /// <param name="id">Id of contact you want to update</param> 
        /// <param name="body">Change the desired values and remove the quotation marks to add an email.    The key represents what type of website it is (1: Private, 2: Work, 3. Fax, 4. Mobil, 5. empty, 6. Autobox, 7. Newsletter, 8. Invoice address)</param> 
        /// <returns></returns>            
        public void ContactAddEmail (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ContactAddEmail");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ContactAddEmail");
            
    
            var path = "/Contact/{id}/addEmail";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ContactAddEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ContactAddEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create a new contact of type person or company With the new version of sevdesk some models are not created by calling the model.php directly but by calling the factory.php because of better performance and flexibility.    Basically the model.php itself still constructs the model however new instances of the model are created trough the factory.php    So for example when you create a new invoice it wont be saved by a POST request with &#39;/Invoice?para1&#x3D;&amp;...&#39; but with the saveInvoice function in Factory.php &#39;Voucher/Factory/saveInvoice?para1&#x3D;&#39;    Creating a new contact of type person/company calls a shared path with the same http-verb.    However, both types require certain parameters which will indicate that their type of contact should be created.    So, using **familyname** or **name** in front of &#39;category&#39; will define if either a person or a company is created
        /// </summary>
        /// <param name="body">Concatenate the following attributes with &#39;&amp;&#39; to the example and put **data[familyname]&#x3D;yourFamilyName&amp;** at the beginning to define the **person** you want to add and remove the quotation marks:  * &amp;data[customerNumber]&#x3D;  * &amp;data[gender]&#x3D; (m,w, empty)  * &amp;data[academicTitle]&#x3D;, &amp;data[titel]&#x3D;  * &amp;data[surename]&#x3D;, &amp;data[name2]&#x3D;  * &amp;data[bankNumber]&#x3D;, &amp;data[bankAccount]&#x3D;, &amp;data[vatNumber]&#x3D;  * &amp;data[defaultCashbackTime]&#x3D;, &amp;data[defaultCashbackPercent]&#x3D;, &amp;data[defaultTimeToPay]&#x3D;  * &amp;data[description]&#x3D;    Concatenate the following attributes with &#39;&amp;&#39; to the example and put **data[name]&#x3D;yourCompanyName&amp;** at the beginning  to define the **company** you want to add and remove the quotation marks:  * &amp;data[name2]&#x3D;  * &amp;data[bankNumber]&#x3D;, &amp;data[bankAccount]&#x3D;, &amp;data[vatNumber]&#x3D;  * &amp;data[defaultCashbackTime]&#x3D;, &amp;data[defaultCashbackPercent]&#x3D;, &amp;data[defaultTimeToPay]&#x3D;  * &amp;data[description]&#x3D;</param> 
        /// <returns>ModelContact</returns>            
        public ModelContact ContactFactoryCreateContact (string body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ContactFactoryCreateContact");
            
    
            var path = "/Contact/Factory/create";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ContactFactoryCreateContact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ContactFactoryCreateContact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelContact) ApiClient.Deserialize(response.Content, typeof(ModelContact), response.Headers);
        }
    
        /// <summary>
        /// Get the addresses of a specified contact Calls getAddresses() in Contact.php to get the addresses of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the addresses from</param> 
        /// <param name="categoryId">Category of addresses you want to get</param> 
        /// <param name="categoryObjectName"></param> 
        /// <returns>ModelContactAddress</returns>            
        public ModelContactAddress ContactGetAddresses (int? id, int? categoryId, string categoryObjectName)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ContactGetAddresses");
            
            // verify the required parameter 'categoryId' is set
            if (categoryId == null) throw new ApiException(400, "Missing required parameter 'categoryId' when calling ContactGetAddresses");
            
            // verify the required parameter 'categoryObjectName' is set
            if (categoryObjectName == null) throw new ApiException(400, "Missing required parameter 'categoryObjectName' when calling ContactGetAddresses");
            
    
            var path = "/Contact/{id}/getAddresses";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (categoryId != null) queryParams.Add("category[id]", ApiClient.ParameterToString(categoryId)); // query parameter
 if (categoryObjectName != null) queryParams.Add("category[objectName]", ApiClient.ParameterToString(categoryObjectName)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ContactGetAddresses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ContactGetAddresses: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelContactAddress) ApiClient.Deserialize(response.Content, typeof(ModelContactAddress), response.Headers);
        }
    
        /// <summary>
        /// Delete an existing contact Calls the delete() function in Contact.php
        /// </summary>
        /// <param name="id">id of contact you want to delete</param> 
        /// <returns></returns>            
        public void DeleteContact (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteContact");
            
    
            var path = "/Contact/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteContact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteContact: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the billing address of a specified contact Calls getBillingAddress() in Contact.php to get the billing address of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the billing address from</param> 
        /// <returns>ModelContactAddress</returns>            
        public ModelContactAddress GetContactBillingAddress (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetContactBillingAddress");
            
    
            var path = "/Contact/{id}/getBillingAddress";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactBillingAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactBillingAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelContactAddress) ApiClient.Deserialize(response.Content, typeof(ModelContactAddress), response.Headers);
        }
    
        /// <summary>
        /// Get the billing email of a specified contact Calls getBillingEmail() in Contact.php to get the billing email of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the billing email from</param> 
        /// <returns>ModelCommunicationWay</returns>            
        public ModelCommunicationWay GetContactBillingEmail (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetContactBillingEmail");
            
    
            var path = "/Contact/{id}/getBillingEmail";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactBillingEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactBillingEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCommunicationWay) ApiClient.Deserialize(response.Content, typeof(ModelCommunicationWay), response.Headers);
        }
    
        /// <summary>
        /// Get the communication ways of a specified contact Calls getCommunicationWays() in Contact.php to get the communication ways of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the communication ways from</param> 
        /// <param name="type">Type of communication ways you want to get</param> 
        /// <returns>ModelCommunicationWay</returns>            
        public ModelCommunicationWay GetContactCommunicationWays (int? id, string type)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetContactCommunicationWays");
            
    
            var path = "/Contact/{id}/getCommunicationWays";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactCommunicationWays: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactCommunicationWays: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCommunicationWay) ApiClient.Deserialize(response.Content, typeof(ModelCommunicationWay), response.Headers);
        }
    
        /// <summary>
        /// Get the main address of a specified contact Calls getMainAddress() in Contact.php to get the main address of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the main address from</param> 
        /// <returns>ModelContactAddress</returns>            
        public ModelContactAddress GetContactMainAddress (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetContactMainAddress");
            
    
            var path = "/Contact/{id}/getMainAddress";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactMainAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactMainAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelContactAddress) ApiClient.Deserialize(response.Content, typeof(ModelContactAddress), response.Headers);
        }
    
        /// <summary>
        /// Get the main email of a specified contact Calls getMainEmail() in Contact.php to get the main email of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the main email from</param> 
        /// <returns>ModelCommunicationWay</returns>            
        public ModelCommunicationWay GetContactMainEmail (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetContactMainEmail");
            
    
            var path = "/Contact/{id}/getMainEmail";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactMainEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactMainEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCommunicationWay) ApiClient.Deserialize(response.Content, typeof(ModelCommunicationWay), response.Headers);
        }
    
        /// <summary>
        /// Get the main mobile of a specified contact Calls getMainMobile() in Contact.php to get the main mobile of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the main mobile from</param> 
        /// <returns>ModelCommunicationWay</returns>            
        public ModelCommunicationWay GetContactMainMobile (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetContactMainMobile");
            
    
            var path = "/Contact/{id}/getMainMobile";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactMainMobile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactMainMobile: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCommunicationWay) ApiClient.Deserialize(response.Content, typeof(ModelCommunicationWay), response.Headers);
        }
    
        /// <summary>
        /// Get the main phone of a specified contact Calls getMainPhone() in Contact.php to get the main phone of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the main phone from</param> 
        /// <returns>ModelCommunicationWay</returns>            
        public ModelCommunicationWay GetContactMainPhone (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetContactMainPhone");
            
    
            var path = "/Contact/{id}/getMainPhone";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactMainPhone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactMainPhone: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCommunicationWay) ApiClient.Deserialize(response.Content, typeof(ModelCommunicationWay), response.Headers);
        }
    
        /// <summary>
        /// Get the main website of a specified contact Calls getMainWebsite() in Contact.php to get the main website of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the main website from</param> 
        /// <returns>ModelCommunicationWay</returns>            
        public ModelCommunicationWay GetContactMainWebsite (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetContactMainWebsite");
            
    
            var path = "/Contact/{id}/getMainWebsite";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactMainWebsite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactMainWebsite: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCommunicationWay) ApiClient.Deserialize(response.Content, typeof(ModelCommunicationWay), response.Headers);
        }
    
        /// <summary>
        /// Get the related communication ways of a specified contact Calls getRelatedCommunicationWays() in Contact.php to get the related communication ways of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the related communication ways from</param> 
        /// <param name="type">Type of related communication ways you want to get</param> 
        /// <returns>ModelCommunicationWay</returns>            
        public ModelCommunicationWay GetContactRelatedCommunicationWays (int? id, string type)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetContactRelatedCommunicationWays");
            
    
            var path = "/Contact/{id}/getRelatedCommunicationWays";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactRelatedCommunicationWays: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactRelatedCommunicationWays: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelCommunicationWay) ApiClient.Deserialize(response.Content, typeof(ModelCommunicationWay), response.Headers);
        }
    
        /// <summary>
        /// Get number of all invoices, orders, etc. of a specified contact Calls getTabsItemCount() in Contact.php to get the number of all invoices, orders, etc. of a specified contact
        /// </summary>
        /// <param name="id">Id of the contact you want to get the number of all invoices, orders, etc. from</param> 
        /// <returns></returns>            
        public void GetContactTabsItemCount (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetContactTabsItemCount");
            
    
            var path = "/Contact/{id}/getTabsItemCount";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactTabsItemCount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContactTabsItemCount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get an overview of all contacts Calls Contact.php to get necessary variables
        /// </summary>
        /// <param name="depth">If depth is set 1 companies and persons will be shown, otherwise only the companies will be shown. Default: 0</param> 
        /// <param name="limit">Limits the number of entries returned. Default is 100</param> 
        /// <param name="offset">Set the index where the returned contacts start. Default is 0</param> 
        /// <param name="embed">Get some additional information. Embed can handle multiple values, they must be separated by comma. Default &#x60;&#x60;.</param> 
        /// <returns>ModelContact</returns>            
        public ModelContact GetContacts (int? depth, int? limit, int? offset, List<string> embed)
        {
            
    
            var path = "/Contact";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (depth != null) queryParams.Add("depth", ApiClient.ParameterToString(depth)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (embed != null) queryParams.Add("embed", ApiClient.ParameterToString(embed)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetContacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelContact) ApiClient.Deserialize(response.Content, typeof(ModelContact), response.Headers);
        }
    
        /// <summary>
        /// Get the next customer number Get the next customer number in the sequence
        /// </summary>
        /// <returns></returns>            
        public void GetNextCustomerNumber ()
        {
            
    
            var path = "/Contact/Factory/getNextCustomerNumber";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNextCustomerNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNextCustomerNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an existing contact Calls Contact.php to update an existing contact
        /// </summary>
        /// <param name="id">Id of contact you want to update</param> 
        /// <param name="body">Parameters which need to be updated. Please be aware not to update any parameters which don&#39;t belong to the type of contact you are updating    Enter the parameters according to the syntax: parameter1&#x3D;&amp;parameter2&#x3D;</param> 
        /// <returns>ModelContact</returns>            
        public ModelContact UpdateContact (int? id, string body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateContact");
            
    
            var path = "/Contact/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateContact: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateContact: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelContact) ApiClient.Deserialize(response.Content, typeof(ModelContact), response.Headers);
        }
    
    }
}
