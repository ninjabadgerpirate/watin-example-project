using WatiN.Core;

namespace WatinExampleProject.Helpers
{
    /// <summary>
    /// This interface allows the BrowserTest helpers class to be extended at a later date.
    /// </summary>
    public interface IBrowserTestHelpers
    {
        /// <summary>
        /// This method returns the the table that matches the tableSelector.
        /// </summary>
        /// <param name="tableSelector">The selector (any jQuery compatible selector) that should be used to find the table.</param>
        /// <returns>Table object.</returns>
        Table ReturnTable(string tableSelector);

        /// <summary>
        /// This method returns the number of rows found in a table that matches the tableSelector.
        /// </summary>
        /// <param name="tableSelector">The selector (any jQuery compatible selector) that should be used to find the table.</param>
        /// <returns>Integer containing the count of rows.</returns>
        int ReturnTableCount(string tableSelector);

        /// <summary>
        /// This method finds the text contained with the table cells of the Address Table.
        /// </summary>
        /// <param name="tableSelector">The selector that should be used to find the browser.</param>
        /// <param name="rowId">The object that contains all the properties required to find the value you are looking for..</param>
        /// <param name="cellId">The object that contains all the properties required to find the value you are looking for..</param>
        /// <returns>A string containing the result.</returns>
        string ReturnTableCellValue(string tableSelector, int rowId, int cellId);

        /// <summary>
        /// This method checks the browser for the specific field that you have specfied
        /// </summary>
        /// <param name="fieldType">The type of field that you are looking for (textbox/select/checkbox/button).</param>
        /// <param name="fieldId">The id of the field that you are looking for.</param>
        /// <returns>Boolean value indicating whether the field was found or not.</returns>
        bool FieldExists(string fieldType, string fieldId);

        /// <summary>
        /// This method checks the browser for to see if the specified Field is enabled.
        /// </summary>
        /// <param name="fieldType">The type of field that you are looking for (textbox/select/checkbox/button).</param>
        /// <param name="fieldId">The id of the field that you are looking for.</param>
        /// <returns>Boolean value indicating whether the field was enabled or not.</returns>
        bool FieldEnabled(string fieldType, string fieldId);

        /// <summary>
        /// This method returns the inner HTML of the HTML tag.
        /// </summary>
        /// <param name="selector">The selector to find the HTML tag.</param>
        /// <returns>A string containing the result.</returns>
        string ReturnInnerHtml(string selector);

        /// <summary>
        /// This method returns the value of an attribute from a field.
        /// </summary>
        /// <param name="fieldId">The field's ID</param>
        /// <param name="fieldType">The type of field that you are looking for.</param>
        /// <param name="attributeName">The name of the attribute that you are looking for</param>
        /// <returns>A string containing the field attribute value.</returns>
        string ReturnFieldAttribute(string fieldId, string fieldType, string attributeName);

        /// <summary>
        /// This method returns a valud from the input field with the id of the fieldId parameter
        /// </summary>
        /// <param name="fieldId"></param>
        /// <returns>A string containing the result.</returns>
        string ReturnTextBoxValue(string fieldId);

        /// <summary>
        /// This method sets a TextBox fields value to the value
        /// </summary>
        /// <param name="fieldId">The Textbox's ID</param>
        /// <param name="value">The value that should be put in the field.</param>
        /// <returns>A boolean value indicating whether the field exists.</returns>
        bool SetTextBoxValue(string fieldId, string value);

        /// <summary>
        /// This method gets the selected value from the select list that corresponds to the FieldId.
        /// </summary>
        /// <param name="fieldId">The select list's ID</param>
        /// <returns>A string containing the result.</returns>
        string ReturnSelectedItem(string fieldId);

        /// <summary>
        /// This method sets the selected value of the select list that corresponds to the FieldId.
        /// </summary>
        /// <param name="fieldId">The select list's ID</param>
        /// <param name="value">The value that you are setting.</param>
        /// <returns>A boolean value indicating whether the select list was found.</returns>
        bool SetSelectedItem(string fieldId, string value);

        /// <summary>
        /// This method fires the jsToRun javascript on the page.
        /// </summary>
        /// <param name="jsToRun">The script that you want to run on the browser page.</param>
        void FireJs(string jsToRun);

        /// <summary>
        /// This method sets the checkbox that corresponds with the FieldId
        /// </summary>
        /// <param name="fieldId">The select list's ID</param>
        /// <returns>A boolean value indicating if the checkbox is checked or not.</returns>
        bool GetCheckboxCheckedStatus(string fieldId);

        /// <summary>
        /// This method sets the checkbox that corresponds with the FieldId
        /// </summary>
        /// <param name="fieldId">The select list's ID</param>
        /// <param name="isChecked">The value that you are setting.</param>
        /// <returns>A boolean value indicating whether the select list was found.</returns>
        bool SetCheckbox(string fieldId, bool isChecked);

        /// <summary>
        /// This method clicks the button that has an id of FieldId
        /// </summary>
        /// <param name="fieldId">The button's ID</param>
        /// <returns>A boolean value indicating whether the select list was found.</returns>
        bool ClickButton(string fieldId);
    }
}
