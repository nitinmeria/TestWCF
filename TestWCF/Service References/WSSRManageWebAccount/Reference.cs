﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWCF.WSSRManageWebAccount {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", ConfigurationName="WSSRManageWebAccount.IManageWebAccountService")]
    public interface IManageWebAccountService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://services.compassionuk.org/ManageWebAccount/IManageWebAccountService/Update" +
            "Address")]
        void UpdateAddress(TestWCF.WSSRManageWebAccount.UpdateAddress request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://services.compassionuk.org/ManageWebAccount/IManageWebAccountService/Reques" +
            "tStatus")]
        void RequestStatus(TestWCF.WSSRManageWebAccount.RequestStatus request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.compassionuk.org/ManageWebAccount/IManageWebAccountService/Update" +
            "SupporterProfileDetails", ReplyAction="http://services.compassionuk.org/ManageWebAccount/IManageWebAccountService/Update" +
            "SupporterProfileDetailsResponse")]
        TestWCF.WSSRManageWebAccount.SupporterProfileDetailsReponse UpdateSupporterProfileDetails(TestWCF.WSSRManageWebAccount.SupporterProfileDetails request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateAddress", WrapperNamespace="http://services.compassionuk.org/ManageWebAccount", IsWrapped=true)]
    public partial class UpdateAddress {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", Order=0)]
        public string address;
        
        public UpdateAddress() {
        }
        
        public UpdateAddress(string address) {
            this.address = address;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RequestStatus", WrapperNamespace="http://services.compassionuk.org/ManageWebAccount", IsWrapped=true)]
    public partial class RequestStatus {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", Order=0)]
        public string status;
        
        public RequestStatus() {
        }
        
        public RequestStatus(string status) {
            this.status = status;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SupporterProfileDetailsObject", WrapperNamespace="http://services.compassionuk.org/ManageWebAccount", IsWrapped=true)]
    public partial class SupporterProfileDetails {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", Order=0)]
        public int supporterid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", Order=1)]
        public int titleid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", Order=2)]
        public string firstname;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", Order=3)]
        public string lastname;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", Order=4)]
        public string email;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", Order=5)]
        public string altemail1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", Order=6)]
        public string altemail2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", Order=7)]
        public string homephone;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", Order=8)]
        public string mobilephone;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", Order=9)]
        public string officephone;
        
        public SupporterProfileDetails() {
        }
        
        public SupporterProfileDetails(int supporterid, int titleid, string firstname, string lastname, string email, string altemail1, string altemail2, string homephone, string mobilephone, string officephone) {
            this.supporterid = supporterid;
            this.titleid = titleid;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.altemail1 = altemail1;
            this.altemail2 = altemail2;
            this.homephone = homephone;
            this.mobilephone = mobilephone;
            this.officephone = officephone;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SupporterProfileDetailsResponseObject", WrapperNamespace="http://services.compassionuk.org/ManageWebAccount", IsWrapped=true)]
    public partial class SupporterProfileDetailsReponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.compassionuk.org/ManageWebAccount", Order=0)]
        public string OperationResult;
        
        public SupporterProfileDetailsReponse() {
        }
        
        public SupporterProfileDetailsReponse(string OperationResult) {
            this.OperationResult = OperationResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IManageWebAccountServiceChannel : TestWCF.WSSRManageWebAccount.IManageWebAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ManageWebAccountServiceClient : System.ServiceModel.ClientBase<TestWCF.WSSRManageWebAccount.IManageWebAccountService>, TestWCF.WSSRManageWebAccount.IManageWebAccountService {
        
        public ManageWebAccountServiceClient() {
        }
        
        public ManageWebAccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ManageWebAccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManageWebAccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManageWebAccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void UpdateAddress(TestWCF.WSSRManageWebAccount.UpdateAddress request) {
            base.Channel.UpdateAddress(request);
        }
        
        public void RequestStatus(TestWCF.WSSRManageWebAccount.RequestStatus request) {
            base.Channel.RequestStatus(request);
        }
        
        public TestWCF.WSSRManageWebAccount.SupporterProfileDetailsReponse UpdateSupporterProfileDetails(TestWCF.WSSRManageWebAccount.SupporterProfileDetails request) {
            return base.Channel.UpdateSupporterProfileDetails(request);
        }
    }
}
