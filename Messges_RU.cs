

namespace _SmartChain_Cs
{ 
    public class Messges_EN : Imessage
{
    //Place code in the module if it shows a message box or warning

    public string MSG_WrongVersion() {return "You are using a version of Radium Core that is too old or too new.\\r\\nThe SmartChain must exit.";}
    public string MSG_RunningWallet() {return "Please make sure ALL instances of the Radium wallet are closed. Radium SmartChain contains its own Radium Wallet implementation, and may conflict with other running Radium wallets. Please close all other Radium wallets and start the SmartChain again."; }
    public string MSG_SucessfullRegestration(){return "SmartTransaction sent! Congratulations! In 4 blocks your new Identity will be registered with the SmartChain. Your new identity will be available under the MY IDENTITIES tab on the left.";}
    public string MSG_SucessfullVerification(){return "SmartTransaction sent! Congratulations! In 4 blocks the selected user will be verified.";}
    public string MSG_SucessfullHash() {  return "SmartTransaction sent! Congratulations! In 4 blocks your file signature will matures and be verifiable with the SmartChain!";}
    public string MSG_SucessfullContract(){return "SmartTransaction sent! Congratulations! In 4 blocks your contract signature verifiable with the SmartChain!";}
    public string MSG_SucessfullDoc(){return "SmartTransaction sent! Congratulations! In 4 blocks your signed note will be available in the SmartChain!";}
    public string MSG_LinkWarning(){return "Address linkage occurs when multiple receiving address within a wallet become associated with one another. This occurs when one address sends funds to another, or inputs" + " from two different addresses are used in one transaction. This is not an error, but rather completely normal operation for any standard coin wallet." + " If two addresses become linked, a block-chain analysis will show that the two linked addresses belong to the same individual. An analysis could show what other addresses a" + " person has used in the past. Address linkage is only a concern for those who want or are seeking strong anonymity. If this is a concern, it would be prudent to keep a second separate" + " wallet for use with the Radium SmartChain."; }
    public string MSG_ContractWarning(){return "ATTENTION! You are about to create an electronic signature, and place it on the file you have" + " selected. This action is intended to have the same legal scope and force of a physical signature." + " Be aware that the legal precedent for digital block chain signatures is unknown." + " Please seek legal guidance from a legal professional who has knowledge of the laws in your local jurisdiction.";}
    public string MSG_GUI_UPDATE(){return "An update for the SmartChain user interface is available. Upgrade at your leisure. Refer to the Radium Core blog or other relevant media sources for more information. ";}
    public string MSG_OPTIONAL_UPDATE(){return "An optional update is available for the SmartChain. Upgrade at your leisure. Refer to the Radium Core blog or other relevant media sources for more information.";}
    public string MSG_Recomended_Update(){return "A recommended update is available for the SmartChain. Please upgrade as soon as possible. Refer to the Radium Core blog or other relevant media sources for more information.";}
    public string MSG_Forced_Update(){return "A REQUIRED UPDATE is available. Required updates usually include fundamental protocol changes that break previous clients. Refer to the Radium Core blog or other relevant media sources for more information.";}

}

}
