using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Languages_CS
{

    public interface ILanguage
    {

        #region "Main Window"
        #region "title bar"
        string Current_Identity { get; }
        string No_Identity_Selected { get; }
        string Radium { get; }
        string Radium_Balance { get; }
        string SmartChain_Blocks { get; }
        #endregion
        string Wallet_Blocks { get; }
        #region "Navigation"
        string Dashboard { get; }
        string Receive { get; }
        string History { get; }
        string Users { get; }
        string Signed_Records { get; }
        string Contracts { get; }
        string My_Identities { get; }
        #endregion
        string Settings { get; }
        #region "File Menu"
        string File { get; }
        string Show_Log { get; }
        string Console { get; }
        string Re_Sync { get; }
        string About { get; }
        string Dev_tools { get; }
        #endregion
        string Install_OCV { get; }


        void update();

        #endregion

        #region "Data Grids"
        //-- Titles --

        string Your_Signed_Contracts { get; }
        // --Column headers
        string Title { get; }
        string Signatures { get; }
        string ID { get; }
        string _Date { get; }
        string Current_Owner { get; }
        string Record_Type { get; }
        string Username { get; }
        string Description { get; }
        //-- buttons 

        string View_Contract { get; }
        string SIGN_OR_VERIFY_CONTRACT { get; }
        string View_Additional_Info { get; }
        string Check_File_Signature { get; }
        string Sign_A_File { get; }
        string Sign_A_Note { get; }
        //-- Filters
        string Filter_By { get; }
        string Verified { get; }
        string All { get; }
        string Signed_Notes { get; }
        string Signed_Files { get; }
        string Open { get; }
        string Closed { get; }
        string Completed { get; }

        string Future { get; }
        #endregion

        #region "Dashboard"
        string Wallet { get; }
        string Spendable { get; }
        string Stake { get; }
        string Unconfirmed { get; }
        string Total { get; }
        string USD_Value { get; }
        string Staking { get; }
        string Last_24_Hours { get; }
        string USD_DAY { get; }
        string Time_To_Reward { get; }
        string Peers { get; }

        string Recent_Transactions { get; }
        #endregion

        #region "Edit User"
        string Editing_user_information_for { get; }
        string Enter_Only_Information_to_edit { get; }
        string ANY_ACCOUNT_CHANGES_require_reverification { get; }
        string Username_30_chars_max { get; }
        string Company_30_chars_max { get; }
        string Phone_30_chars_max { get; }
        string Description_30_chars_max { get; }
        string Email_30_chars_max { get; }
        string Website_60_chars_max { get; }
        string Streed_Address_30_chars_max { get; }
        string Edit_This_Field { get; }

        string Address { get; }

        #endregion

        #region "User Registration"
        string Create_New_SmartChain_Identity { get; }
        string Step_One { get; }

        string _OR { get; }
        string Step_Two_Enter_Info { get; }
        string _optional { get; }

        string _required { get; }

        #endregion



        #region "My_Identities"

        string Smartchain_Registered_Identites { get; }
        #endregion
        string Double_click_for_additonal_Check_means_verified { get; }

        #region "Select Identity"
        string Your_Identities { get; }
        string Double_Click_to_select_identity { get; }
        string Create_new_identity { get; }
        string Use_selected_identity { get; }

        string Edit_Selected_Identity { get; }
        #endregion

        #region "Common Buttons"
        string Confirm { get; }
        string Cancel { get; }
        string Create_New_address { get; }
        string Select_Existing_address { get; }
        string Create_Identity { get; }

        string Back { get; }
        #endregion

        #region "Forms"
        #region "About.xaml"
        #region "Heading"

        string About_Window_Title { get; }
        #endregion
        string About_Heading { get; }
        #region "Body"

        string About_Credits_Intro { get; }

        string About_Tim { get; }

        string About_Alaniz { get; }

        string About_Goblynn { get; }

        string About_Cris { get; }

        string About_TheJTizzle { get; }

        string About_Dev0tion { get; }

        string About_Lamptoast { get; }

        string About_Ganastor { get; }

        string About_CRZ { get; }
        #endregion
        string About_Dlow { get; }
        #region "Footer"

        string About_Copyright { get; }
        #endregion
        string About_Experimental { get; }
        #region "Buttons"

        string About_EULA { get; }

        string About_Privacy { get; }
        #endregion
        string About_Close { get; }
        #endregion

        #region "AddressBook.xaml"
        #region "Header"

        string AddressBook_Form_Title { get; }
        #endregion
        string AddressBook_Form_Heading { get; }
        #region "Body"

        string AddressBook_Datagrid_Tab_Label { get; }
        #endregion
        string AddressBook_Datagrid_Tab_Address { get; }
        #region "Buttons"

        string AddressBook_Button_New { get; }

        string AddressBook_Button_Copy { get; }

        string AddressBook_Button_Sign { get; }
        #endregion
        string AddressBook_Button_OK { get; }
        #endregion

        #region "CheckHash.xaml"
        #region "Header"

        string CheckHash_Form_Title { get; }
        #endregion
        string CheckHash_Form_Heading { get; }
        #region "Body"

        string Signer { get; }
        string Date_Signed { get; }
        string Digital_Signature { get; }
        string Recording_Transaction { get; }
        string Double_click_to_view_on_chainz { get; }
        #endregion
        string Radium_Address { get; }
        #region "Buttons"
        #endregion
        string CheckHash_Buttons_Select_File { get; }
        #endregion

        #region "CheckHash_OCV.xaml"
        #region "Header"

        string CheckHash_OCV_Form_Title { get; }

        #endregion
        #region "Body"

        string No_File_Specified { get; }

        string Hashing { get; }
        string Contacting_Server { get; }
        string Server_Down { get; }
        string File_Not_signed { get; }
        #endregion
        string Known_File { get; }

        #endregion

        #region "Console.xaml"
        //Skipping Console.xaml for now, needs more translation than allowed here.
        #endregion

        #region "ContractFind.xaml"
        //Skipping for now.
        #endregion

        #region "ContractViewer.xaml"
        //Skipping for now.
        #endregion

        #region "DevTools.xaml"
        #region "Header"

        string DevTools_Window_Title { get; }
        #endregion
        string DevTools_Header { get; }
        #region "Body"

        string DevTools_Body_Title { get; }

        string DevTools_Current_Version_Title { get; }

        string DevTools_Latest_GUI { get; }

        string DevTools_Latest_Optional { get; }

        string DevTools_Latest_Recommended { get; }
        #endregion
        string DevTools_Forced { get; }
        #region "Buttons"
        #endregion
        string DevTools_Set_Button { get; }
        #endregion

        #region "DocReader.xaml"
        #region "Header"
        #endregion
        string DocReader_Window_Title { get; }
        #region "Body"

        string DocReader_Signed_By { get; }

        string DocReader_In_Block { get; }
        #endregion
        string DocReader_Date { get; }
        #endregion

        #region "EditLabel.xaml"
        #region "Header"
        #endregion
        string EditLabel_Window_Title { get; }
        #region "Body"
        #endregion
        string EditLabel_New_Label_Title { get; }
        #region "Buttons"

        string EditLabel_Ok_Button { get; }
        #endregion
        string EditLabel_Cancel_Button { get; }
        #endregion

        #region "Elections"
        string Filter_Elections_By_Status { get; }
        string Smartchain_Voting { get; }

        string Smartchain_Election { get; }
        string Double_Click_To_View_Election { get; }
        string Create_An_Election { get; }
        string Status { get; }
        string Available_Elections { get; }
        string Election_Status { get; }
        string Voting { get; }

        string Created_By { get; }
        //Cast vote
        string About_To_vote_For { get; }
        string In_election_titled { get; }
        string Election_ID { get; }
        string This_Election_Closes_At { get; }
        string Verify_Correct { get; }

        string Cast_Vote { get; }
        // Create Election
        string Setup_New_Election { get; }
        string Title_30_chars_max { get; }
        string Title_60_chars_max { get; }
        string Open_Election { get; }
        string Now { get; }
        string In_The_Future { get; }
        string How_Long_should_it_Run { get; }
        string Candidates { get; }
        string Add_Candidate { get; }
        string Candidate_Text { get; }
        string Create { get; }
        string Language { get; }
        string Election_Times_Are_Estimates { get; }

        string Open_In { get; }
        //Election Participants
        string Election_Start { get; }
        string Election_End { get; }
        string Current_Status { get; }
        string List_Of_Voters { get; }
        string Voted_For { get; }
        string Time_Of_Vote { get; }

        string All_Voters { get; }
        //View election
        string Your_Status { get; }
        string Right_Click_TO_Vote { get; }
        string votes { get; }

        string View_All_Participants { get; }
        #endregion

        #region "EULA.xaml"
        #region "Header"

        string EULA_Window_Title { get; }
        #endregion
        string EULA_Header { get; }
        #region "Body"

        string EULA_Introduction_Text { get; }
        #endregion
        string EULA_Closing_Text { get; }
        #region "Buttons"

        string EULA_Close_Button { get; }
        #endregion
        string EULA_Agree_Button { get; }
        #endregion

        #region "EULA_NoConfirm.xaml"
        #region "Header"

        string EULA_NoConfirm_Window_Title { get; }
        #endregion
        string EULA_NoConfirm_Header { get; }
        #region "Body"
        #endregion
        string EULA_NoConfirm_Introduction_Text { get; }
        #region "Buttons"
        #endregion
        string EULA_NoConfirm_Close_Button { get; }
        #endregion

        #region "FingerprintViewer.xaml"
        #region "Header"

        string FingerprintViewer_Window_Title { get; }
        #endregion
        string FingerprintViewer_Header { get; }
        #region "Body"

        string FingerprintViewer_Title { get; }

        string FingerprintViewer_Signed_By { get; }

        string FingerprintViewer_Radium_Address { get; }

        string FingerprintViewer_Date_Signed { get; }

        string FingerprintViewer_Digital_Signature { get; }

        string FingerprintViewer_Recording_Transaction_Head { get; }
        #endregion
        string FingerprintViewer_Recording_Transaction_Sub { get; }
        #endregion

        #region "NewAddress.xaml"
        #region "Header"
        #endregion
        string NewAddress_Window_Title { get; }
        #region "Body"
        #endregion
        string NewAddress_Main_Label { get; }
        #region "Buttons"

        string NewAddress_OK_Button { get; }
        #endregion
        string NewAddress_Cancel_Button { get; }
        #endregion

        #region "PasswordInput.xaml"
        #region "Header"

        string PasswordInput_Window_Title { get; }
        #endregion
        string PasswordInput_Header { get; }
        #region "Body"
        #endregion
        string PasswordInput_Description { get; }
        #region "Buttons"

        string PasswordInput_Unlock_Button { get; }
        #endregion
        string PasswordInput_Cancel_Button { get; }
        #endregion

        #region "Privacy.xaml"
        #region "Header"

        string Privacy_Window_Title { get; }
        #endregion
        string Privacy_Header { get; }
        #region "Body"
        #endregion
        string Privacy_Description { get; }
        #region "Buttons"
        #endregion
        string Privacy_Cancel_Button { get; }
        #endregion

        #region "RecordDocument.xaml"
        #region "Header"

        string RecordDocument_Window_Title { get; }
        #endregion
        string RecordDocument_Header { get; }
        #region "Body"

        string RecordDocument_Signing_Identity { get; }

        string RecordDocument_Select_Language { get; }

        string RecordDocument_Title { get; }
        #endregion
        string RecordDocument_Content { get; }
        #region "Buttons"

        string RecordDocument_Sign_And_Record { get; }
        #endregion
        string RecordDocument_Calculate_Cost { get; }
        #endregion

        #region "RecordHash.xaml"
        #region "Header"

        string RecordHash_Window_Title { get; }
        #endregion
        string RecordHash_Header { get; }
        #region "Body"

        string RecordHash_Select_A_File { get; }
        #endregion
        string RecordHash_Add_A_Title { get; }
        #region "Buttons"
        #endregion
        string RecordHash_Select_File_Button { get; }
        #endregion

        #region "SelectExistingAddress.xaml"
        #region "Header"

        string SelectExistingAddress_Window_Title { get; }
        #endregion
        string SelectExistingAddress_Header { get; }
        #region "Body"

        string SelectExistingAddress_Description { get; }

        string SelectExistingAddress_Label { get; }
        #endregion
        string SelectExistingAddress_Address { get; }
        #region "Buttons"

        string SelectExistingAddress_Select_Button { get; }
        #endregion
        string SelectExistingAddress_Cancel_Button { get; }
        #endregion

        #region "SettingsForm.xaml"
        #region "Header"
        #endregion
        string SettingsForm_Window_Title { get; }
        #region "Body"

        string SettingsForm_Use_Slow_Sync { get; }
        #endregion
        string SettingsForm_Language { get; }
        #endregion

        #region "SignVerifyMessage.xaml"
        //Skipping SignVerifyMessage.xaml for now.
        //TODO: Re-style form?
        #endregion

        #region "SplashPage.xaml"
        //Skipping SplashPage.xaml for now.
        //TODO: Fix markup issues.
        #endregion

        #region "UserDetails.xaml"
        //Skipping UserDetails.xaml for now.
        //TODO: Fix markup issues.
        #endregion
        #endregion

        #region "Common Words"
        string DAYS { get; }
        string HOURS { get; }
        string MINUTES { get; }
        string No { get; }
        string Yes { get; }
        string Ok { get; }

        string _Continue { get; }
        #endregion
    }



    //            Text="{Binding GUI_TEXT.test, UpdateSourceTrigger=PropertyChanged, FallbackValue=-didntwork}"


}
