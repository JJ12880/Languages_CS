
using System.ComponentModel;


namespace Languages_CS
{
        public class GUI_ENG : ILanguage, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }


        // Translation Instructions:
        // 1) Change the name of the file from GUI_ENG to GUI_(Language code)
        // 2) Translate the initialized property values from English to new language

        // EXAMPLE
        //     ORIGINAL
        //          ReadOnly Property Hello As String = "Hello" Implements ILanguage.Current_Identity
        //                                               ^^^^
        //     NEW
        //          ReadOnly Property Hello As String = "Hola" Implements ILanguage.Current_Identity
        //                                               ^^^^
        // TEMPORARY NOTE: {Binding GUI_TEXT.PROPERTY, UpdateSourceTrigger=PropertyChanged, FallbackValue=-FALLBACK_TEXT}
        

        public void update()
        {
          NotifyPropertyChanged("");
        }

        #region "Main Window"
        #region "title bar"
       
        public string Current_Identity { get { return "Current Identity"; } } 
        public string No_Identity_Selected { get { return "No Identity Selected"; } }
        public string Radium { get { return "Radium"; } }
        public string Radium_Balance { get { return "Radium Balance"; } }



        public string SmartChain_Blocks { get { return "SC Blocks"; } }
        public string Wallet_Blocks { get { return "Wallet Blocks"; } }
        #endregion
        #region "Navigation"
        public string Dashboard { get { return "Dashboard"; } }
        public string Receive { get { return "Receive"; } }
        public string History { get { return "History"; } }
        public string Users { get { return "Users"; } }
        public string Signed_Records { get { return "Signed Records"; } }
        public string Contracts { get { return "Contracts"; } }
        public string My_Identities { get { return "My Identities"; } }
        public string Settings { get { return "Settings"; } }
        #endregion
            #region "File Menu"
            public string File { get { return "File"; } }
        public string Show_Log { get { return "Show Log"; } }
        public string Console { get { return "Console"; } }
        public string Re_Sync { get { return "Re Sync"; } }
        public string About { get { return "About"; } }
        public string Dev_tools { get { return "Dev Tools"; } }
        public string Install_OCV { get { return "Install One Click Verify"; } }
        #endregion
        #endregion

        #region "Data Grids"
        //-- Titles --
        public string Your_Signed_Contracts { get { return "Your Signed Contracts"; } }

        // --Column headers
        public string Title { get { return "Title"; } }
        public string Signatures { get { return "Signatures"; } }
        public string ID { get { return "ID"; } }
        public string _Date { get { return "Date"; } }
        public string Current_Owner { get { return "Current Owner"; } }
        public string Record_Type { get { return "Record Type"; } }
        public string Username { get { return "Username"; } }
        public string Description { get { return "Description"; } }


        //-- buttons
        public string View_Contract { get { return "View Contract"; } }
        public string SIGN_OR_VERIFY_CONTRACT { get { return "Sign Or Verify Contract"; } }
        public string View_Additional_Info { get { return "View Additional Info"; } }
        public string Check_File_Signature { get { return "Check File Signature"; } }
        public string Sign_A_File { get { return "Sign a File"; } }
        public string Sign_A_Note { get { return "Sign a Note"; } }



        //-- Filters
        public string Filter_By { get { return "Filter By"; } }
        public string Verified { get { return "Verified"; } }
        public string All { get { return "All"; } }
        public string Signed_Notes { get { return "Signed Notes"; } }
        public string Signed_Files{ get { return "Signed Files"; } }
        public string Open { get { return "Open"; } }
        public string Closed { get { return "Closed"; } }
        public string Completed { get { return "Completed"; } }
        public string Future { get { return "Future"; } }


        #endregion


        #region "Dashboard"
        public string Wallet { get { return "Wallet"; } }
        public string Spendable { get { return "Spendable"; } }
        public string Stake { get { return "Stake"; } }
        public string Unconfirmed { get { return "Unconfirmed"; } }
        public string Total { get { return "Total"; } }
        public string USD_Value { get { return "USD Value"; } }
        public string Staking { get { return "Staking"; } }
        public string Last_24_Hours { get { return "Last 24 Hours"; } }
        public string USD_DAY { get { return "USD/DAY"; } }
        public string Time_To_Reward { get { return "Time to Reward"; } }
        public string Peers { get { return "Peers"; } }
        public string Recent_Transactions { get { return "Recent Transactions"; } }

        #endregion

        #region "Edit User"
        public string Editing_user_information_for { get { return "Editing User Information For: "; } }
        public string Enter_Only_Information_to_edit { get { return "Enter ONLY the information you wish to edit "; } }
        public string ANY_ACCOUNT_CHANGES_require_reverification { get { return "ANY Account Changes will require re-verification"; } }
        public string Username_30_chars_max { get { return "Username (30 chars max)"; } }
        public string Company_30_chars_max { get { return "Company (30 chars max)"; } }
        public string Phone_30_chars_max { get { return "Phone (30 chars max)"; } }
        public string Description_30_chars_max { get { return "Description (30 chars max)"; } }
        public string Email_30_chars_max { get { return "Email (30 chars max)"; } }
        public string Website_60_chars_max { get { return "Website (60 chars max)"; } }
        public string Streed_Address_30_chars_max { get { return "Street Address (30 chars max)"; } }
        public string Edit_This_Field { get { return "Edit This Field"; } }
        public string Address { get { return "Address"; } }


        #endregion

        #region "User Registration"
        public string Create_New_SmartChain_Identity { get { return "Create New SmartChain Identity"; } }
        public string Step_One { get { return "Step One"; } }
        public string _OR { get { return "OR"; } }

        public string Step_Two_Enter_Info { get { return "Step Two: Enter Information "; } }
        public string _optional { get { return "(optional)"; } }
        public string _required { get { return "(required)"; } }


        #endregion
        #region "Polls"
        public string Filter_Elections_By_Status { get { return "Filter Elections By Status"; } }
        public string Smartchain_Voting { get { return "Smartchain Voting"; } }
        public string Smartchain_Election { get { return "Smartchain Election"; } }

        public string Double_Click_To_View_Election { get { return "Double Click To View Election"; } }
        public string Create_An_Election { get { return "Create An Election"; } }
        public string Status { get { return "Status"; } }
        public string Available_Elections { get { return "Available Elections"; } }
        public string Election_Status { get { return "Election Status"; } }
        public string Voting { get { return "Voting"; } }
        public string Created_By { get { return "Created By"; } }


        //Cast vote
        public string About_To_vote_For { get { return "You are about to vote for:"; } }
        public string In_election_titled { get { return "In Election titled:"; } }
        public string Election_ID { get { return "Election ID"; } }
        public string This_Election_Closes_At { get { return "This Election Closes at"; } }
        public string Verify_Correct { get { return "Please verify the above information is correct!. Votes can not be changed or altered once they are cast. Only one vote per identity will be recorded."; } }
        public string Cast_Vote { get { return "Cast Vote"; } }

        // Create Election
        public string Setup_New_Election { get { return "Setup a new Election"; } }
        public string Title_30_chars_max { get { return "Title. (30 chars max)"; } }
        public string Title_60_chars_max { get { return "Title. (60 chars max)"; } }
        public string Open_Election { get { return "Open Election:"; } }
        public string Now { get { return "Now"; } }
        public string In_The_Future { get { return "In the future"; } }
        public string How_Long_should_it_Run { get { return "How long should the election last?"; } }
        public string Candidates { get { return "Candidates"; } }
        public string Add_Candidate { get { return "Add Candidate"; } }
        public string Candidate_Text { get { return "Enter Candidate Name"; } }
        public string Create { get { return "Create"; } }
        public string Language { get { return "Language"; } }
        public string Election_Times_Are_Estimates { get { return "Due to possible variations in block speeds, election open and close times are estimates!"; } }
        public string Open_In { get { return "Open In:"; } }
        //Election Participants
        public string Election_Start { get { return "Election Start Time"; } }
        public string Election_End { get { return "Election End Time"; } }
        public string Current_Status { get { return "Election Status"; } }
        public string List_Of_Voters { get { return "Voters participating in this election. (Double click for identity information)"; } }
        public string Voted_For { get { return "Voted For"; } }
        public string Time_Of_Vote { get { return "Time of Vote"; } }
        public string All_Voters { get { return "All Voters"; } }
        //View election
        public string Your_Status { get { return "Your Status"; } }
        public string Right_Click_TO_Vote { get { return "Candidates. Right click on candidate to cast vote."; } }
        public string votes { get { return "Votes"; } }
        public string View_All_Participants { get { return "View All Participants"; } }


        #endregion
        #region "My_Identities"
        public string Smartchain_Registered_Identites { get { return "Smartchain Registered Identities"; } }

        public string Double_click_for_additonal_Check_means_verified { get { return "Double click a user To view additional information.  A '✔' after a username indicates third-party verification. "; } }
        #endregion

        #region "Select Identity"
        public string Your_Identities { get { return "Your Identities"; } }
        public string Double_Click_to_select_identity { get { return "Double Click to Select Identity"; } }
        public string Create_new_identity { get { return "Create New Identity"; } }
        public string Use_selected_identity { get { return "Use Selected Identity"; } }
        public string Edit_Selected_Identity { get { return "Edit Selected Identity"; } }

        #endregion

        #region "Common Buttons"
        public string Confirm { get { return "Confirm"; } }
        public string Cancel { get { return "Cancel"; } }
        public string Create_New_address { get { return "Create New Address"; } }
        public string Select_Existing_address { get { return "Select Existing Address"; } }
        public string Create_Identity { get { return "Create Identity"; } }
        public string Back { get { return "Back"; } }

        #endregion

        #region "Forms"
        #region "About.xaml"
        #region "Heading"
        public string About_Window_Title { get { return "Radium SmartChain End User License Agreement"; } }

        public string About_Heading { get { return "About Radium SmartChain"; } }
        #endregion
        #region "Body"
        public string About_Credits_Intro { get { return "This project would not have been possible without the following people. "; } }

        public string About_Tim { get { return "      Timothy Mesker (tm2013) and the support of  Project Radium, LLC"; } }

        public string About_Alaniz { get { return "      Alaniz and his leadership of Radium Core"; } }

        public string About_Goblynn { get { return "      Goblynn and his continued organizational guidance and beta testing."; } }

        public string About_Cris { get { return "      cris_conte and his meticulous beta testing"; } }

        public string About_TheJTizzle { get { return "      TheJTizzle and his work developing the Radium Icon pack"; } }

        public string About_Dev0tion { get { return "      Dev0tion and the initial GUI design and their WPF and .NET experience."; } }

        public string About_Lamptoast { get { return "      Lamptoast for his contributions to rapid deploy code."; } }

        public string About_Ganastor { get { return "      Ganastor and his various docker, networking, and database wisdom."; } }

        public string About_CRZ { get { return "      CRZ for the color pallet and BCT ANN design. "; } }

        public string About_Dlow { get { return "      dlow for his contributions to the Radium graphics. "; } }
        #endregion
        #region "Footer"
        public string About_Copyright { get { return "Copyright 2017 by SmartChain Software Solutions, LLC "; } }

        public string About_Experimental { get { return "This is experimental software, distributed under an End User License Agreement and Privacy Policy.  "; } }
        #endregion
        #region "Buttons"
        public string About_EULA { get { return "View EULA"; } }

        public string About_Privacy { get { return "View Privacy Policy"; } }

        public string About_Close { get { return "Close"; } }
        #endregion
        #endregion

        #region "AddressBook.xaml"
        #region "Header"
        public string AddressBook_Form_Title { get { return "AddressBook"; } }

        public string AddressBook_Form_Heading { get { return "Your Radium Addresses"; } }
        #endregion
        #region "Body"
        public string AddressBook_Datagrid_Tab_Label { get { return "Label"; } }

        public string AddressBook_Datagrid_Tab_Address { get { return "address"; } }
        #endregion
        #region "Buttons"
        public string AddressBook_Button_New { get { return "New Address"; } }

        public string AddressBook_Button_Copy { get { return "Copy Address"; } }

        public string AddressBook_Button_Sign { get { return "Sign Message"; } }

        public string AddressBook_Button_OK { get { return "Ok"; } }
        #endregion
        #endregion

        #region "CheckHash.xaml"
        #region "Header"
        public string CheckHash_Form_Title { get { return "Check File Signature"; } }

        public string CheckHash_Form_Heading { get { return "Check File Signature"; } }
        #endregion
        #region "Body"
        public string Signer { get { return "Signer"; } }
        public string Date_Signed { get { return "Date Signed"; } }
        public string Digital_Signature { get { return "Digital Signature"; } }
        public string Recording_Transaction { get { return "Recording Transaction"; } }
        public string Double_click_to_view_on_chainz { get { return "(double click to view on Chainz)"; } }
        public string Radium_Address { get { return "Radium Address"; } }
        #endregion
        #region "Buttons"
        public string CheckHash_Buttons_Select_File { get { return "Select File"; } }
        #endregion
        #endregion

        #region "CheckHash_OCV.xaml"
        #region "Header"
        public string CheckHash_OCV_Form_Title { get { return "SmartChain Check File Signature"; } }


        #endregion
        #region "Body"
        public string No_File_Specified { get { return "No File Specified"; } }
        public string Hashing { get { return "Hashing"; } }

        public string Contacting_Server { get { return "Contacting Server"; } }
        public string Server_Down { get { return "Server is down. Please contact administrator!"; } }
        public string File_Not_signed { get { return "File is not signed "; } }
        public string Known_File { get { return "Known File"; } }

        #endregion

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
        public string DevTools_Window_Title { get { return "Development Tools"; } }

        public string DevTools_Header { get { return "Development Tools"; } }
        #endregion
        #region "Body"
        public string DevTools_Body_Title { get { return "Enter ONLY the information to edit."; } }

        public string DevTools_Current_Version_Title { get { return "Current Version is: "; } }

        public string DevTools_Latest_GUI { get { return "Latest GUI"; } }

        public string DevTools_Latest_Optional { get { return "Latest Optional"; } }

        public string DevTools_Latest_Recommended { get { return "Latest Recommended"; } }

        public string DevTools_Forced { get { return "Forced."; } }
        #endregion
        #region "Buttons"
        public string DevTools_Set_Button { get { return "Set"; } }
        #endregion
        #endregion

        #region "DocReader.xaml"
        #region "Header"
        public string DocReader_Window_Title { get { return "SmartChain Note"; } }
        #endregion
        #region "Body"
        public string DocReader_Signed_By { get { return "Signed By"; } }

        public string DocReader_In_Block { get { return "In Block"; } }

        public string DocReader_Date { get { return "Date"; } }
        #endregion
        #endregion

        #region "EditLabel.xaml"
        #region "Header"
        public string EditLabel_Window_Title { get { return "Edit Label"; } }
        #endregion
        #region "Body"
        public string EditLabel_New_Label_Title { get { return "New Label"; } }
        #endregion
        #region "Buttons"
        public string EditLabel_Ok_Button { get { return "Ok"; } }

        public string EditLabel_Cancel_Button { get { return "Cancel"; } }
        #endregion
        #endregion

        #region "EULA.xaml"
        #region "Header"
        public string EULA_Window_Title { get { return "Radium SmartChain End User License Agreement"; } }

        public string EULA_Header { get { return "Welcome to SmartChain!"; } }
        #endregion
        #region "Body"
        public string EULA_Introduction_Text { get { return "Please take a moment to read our End User License Agreement"; } }

        public string EULA_Closing_Text { get { return "By clicking the 'Agree and Continue' button you are agreeing to be bound by the terms and conditions of this above Agreement."; } }
        #endregion
        #region "Buttons"
        public string EULA_Close_Button { get { return "Close"; } }

        public string EULA_Agree_Button { get { return "Agree and Continue"; } }
        #endregion
        #endregion

        #region "EULA_NoConfirm.xaml"
        #region "Header"
        public string EULA_NoConfirm_Window_Title { get { return "Radium SmartChain End User License Agreement"; } }

        public string EULA_NoConfirm_Header { get { return "Welcome to SmartChain!"; } }
        #endregion
        #region "Body"
        public string EULA_NoConfirm_Introduction_Text { get { return "Please take a moment to read our End User License Agreement"; } }
        #endregion
        #region "Buttons"
        public string EULA_NoConfirm_Close_Button { get { return "Close"; } }
        #endregion
        #endregion

        #region "FingerprintViewer.xaml"
        #region "Header"
        public string FingerprintViewer_Window_Title { get { return "File Signature Details"; } }

        public string FingerprintViewer_Header { get { return "SmartChain File Signature Details"; } }
        #endregion
        #region "Body"
        public string FingerprintViewer_Title { get { return "Title: "; } }

        public string FingerprintViewer_Signed_By { get { return "Signed By: "; } }

        public string FingerprintViewer_Radium_Address { get { return "Radium Address: "; } }

        public string FingerprintViewer_Date_Signed { get { return "Date Signed: "; } }

        public string FingerprintViewer_Digital_Signature { get { return "Digital Signature: "; } }

        public string FingerprintViewer_Recording_Transaction_Head { get { return "Recording Transaction: "; } }

        public string FingerprintViewer_Recording_Transaction_Sub { get { return "(Double click to view on Chainz)"; } }
        #endregion
        #endregion

        #region "NewAddress.xaml"
        #region "Header"
        public string NewAddress_Window_Title { get { return "New receiving address"; } }
        #endregion
        #region "Body"
        public string NewAddress_Main_Label { get { return "Label"; } }
        #endregion
        #region "Buttons"
        public string NewAddress_OK_Button { get { return "OK"; } }

        public string NewAddress_Cancel_Button { get { return "Cancel"; } }
        #endregion
        #endregion

        #region "PasswordInput.xaml"
        #region "Header"
        public string PasswordInput_Window_Title { get { return "Enter passphrase"; } }


        public string PasswordInput_Header { get { return "Passphrase"; } }
        #endregion
        #region "Body"
        public string PasswordInput_Description { get { return "Your wallet is encrypted! Please enter your decryption passphrase."; } }
        #endregion
        #region "Buttons"
        public string PasswordInput_Unlock_Button { get { return "Unlock"; } }

        public string PasswordInput_Cancel_Button { get { return "Cancel"; } }
        #endregion
        #endregion

        #region "Privacy.xaml"
        #region "Header"
        public string Privacy_Window_Title { get { return "Radium SmartChain Privacy Policy"; } }

        public string Privacy_Header { get { return "Radium SmartChain Privacy Policy"; } }
        #endregion
        #region "Body"
        public string Privacy_Description { get { return "Please take a moment to read our Privacy Policy"; } }
        #endregion
        #region "Buttons"
        public string Privacy_Cancel_Button { get { return "Cancel"; } }
        #endregion
        #endregion

        #region "RecordDocument.xaml"
        #region "Header"
        public string RecordDocument_Window_Title { get { return "Sign SmartChain Note"; } }

        public string RecordDocument_Header { get { return "Sign and Record a SmartChain Note"; } }
        #endregion
        #region "Body"
        public string RecordDocument_Signing_Identity { get { return "Signing Identity: "; } }

        public string RecordDocument_Select_Language { get { return "Select Language: "; } }

        public string RecordDocument_Title { get { return "TITLE (90 chars max)"; } }

        public string RecordDocument_Content { get { return "CONTENT"; } }
        #endregion
        #region "Buttons"
        public string RecordDocument_Sign_And_Record { get { return "Sign and Record"; } }

        public string RecordDocument_Calculate_Cost { get { return "Calculate Cost"; } }
        #endregion
        #endregion

        #region "RecordHash.xaml"
        #region "Header"
        public string RecordHash_Window_Title { get { return "Sign a File"; } }

        public string RecordHash_Header { get { return "Sign a file with your SmartChain Identity"; } }
        #endregion
        #region "Body"
        public string RecordHash_Select_A_File { get { return "Select a file: "; } }

        public string RecordHash_Add_A_Title { get { return "Add a title (optional): "; } }
        #endregion
        #region "Buttons"
        public string RecordHash_Select_File_Button { get { return "SELECT FILE"; } }
        #endregion
        #endregion

        #region "SelectExistingAddress.xaml"
        #region "Header"
        public string SelectExistingAddress_Window_Title { get { return "Select Existing Address"; } }

        public string SelectExistingAddress_Header { get { return "Select Existing Address"; } }
        #endregion
        #region "Body"
        public string SelectExistingAddress_Description { get { return "These are your radium addresses for receiving payments. You may want to give a different one to each sender so you can keep track of who is paying you."; } }

        public string SelectExistingAddress_Label { get { return "LABEL"; } }

        public string SelectExistingAddress_Address { get { return "ADDRESS"; } }
        #endregion
        #region "Buttons"
        public string SelectExistingAddress_Select_Button { get { return "Select"; } }

        public string SelectExistingAddress_Cancel_Button { get { return "Cancel"; } }
        #endregion
        #endregion

        #region "SettingsForm.xaml"
        #region "Header"
        public string SettingsForm_Window_Title { get { return "Settings"; } }
        #endregion
        #region "Body"
        public string SettingsForm_Use_Slow_Sync { get { return "Use Slow Sync"; } }

        public string SettingsForm_Language { get { return "Language"; } }
        #endregion
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
        public string DAYS { get { return "Days"; } }
        public string HOURS { get { return "Hours"; } }
        public string MINUTES { get { return "Minutes"; } }
        public string No { get { return "No"; } }
        public string Yes { get { return "Yes"; } }
        public string Ok { get { return "OK"; } }
        public string _Continue { get { return "Continue"; } }
       
        #endregion

    }
   
    //=======================================================
    //Service provided by Telerik (www.telerik.com)
    //Conversion powered by NRefactory.
    //Twitter: @telerik
    //Facebook: facebook.com/telerik
    //=======================================================

}
