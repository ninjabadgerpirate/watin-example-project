using WatiN.Core;

namespace WatinExampleProject.Helpers
{
    public class BrowserTestHelpers : IBrowserTestHelpers
    {
        /// <summary>
        /// The browser that you are using
        /// </summary>
        private readonly IE _browser;

        /// <summary>
        /// Constructor that takes in the Browser instance that should be used.
        /// </summary>
        /// <param name="browser"></param>
        public BrowserTestHelpers(IE browser)
        {
            _browser = browser;
        }

        /// <summary>
        /// This method returns the number of rows found in a table that matches the tableSelector.
        /// </summary>
        /// <param name="tableSelector">The selector (any jQuery compatible selector) that should be used to find the table.</param>
        /// <returns>Integer containing the count of rows.</returns>
        public int ReturnTableCount(string tableSelector)
        {
            int result = 0;
            var table = _browser.Table(Find.BySelector(tableSelector));
            if (table != null)
            {
                result = table.TableRows.Count;
            }
            return result;
        }

        /// <summary>
        /// This method returns the the table that matches the tableSelector.
        /// </summary>
        /// <param name="tableSelector">The selector (any jQuery compatible selector) that should be used to find the table.</param>
        /// <returns>Table object.</returns>
        public Table ReturnTable(string tableSelector)
        {
            return _browser.Table(Find.BySelector(tableSelector));
        }

        /// <summary>
        /// This method finds the text contained with the table cells of the Address Table.
        /// </summary>
        /// <param name="tableSelector">The selector that should be used to find the browser.</param>
        /// <param name="rowId">The object that contains all the properties required to find the value you are looking for..</param>
        /// <param name="cellId">The object that contains all the properties required to find the value you are looking for..</param>
        /// <returns>A string containing the result.</returns>
        public string ReturnTableCellValue(string tableSelector, int rowId, int cellId)
        {
            var result = string.Empty;
            var table = _browser.Table(Find.BySelector(tableSelector));
            if (table.TableRows.Count - 1 < rowId) return result;
            TableRow tr = table.TableRows[rowId];
            if (tr == null) return result;
            var td = tr.TableCells[cellId];
            result = td.Text ?? string.Empty;

            return result;
        }

        /// <summary>
        /// This method checks the browser for the specific field that you have specfied
        /// </summary>
        /// <param name="fieldType">The type of field that you are looking for (textbox/select/checkbox/button).</param>
        /// <param name="fieldId">The id of the field that you are looking for.</param>
        /// <returns>Boolean value indicating whether the field was found or not.</returns>
        public bool FieldExists(string fieldType, string fieldId)
        {
            switch (fieldType.ToLower())
            {
                case "textbox":
                    return _browser.ElementOfType<TextFieldExtended>(Find.ById(fieldId)) != null;
                case "select":
                    return _browser.SelectList(Find.ById(fieldId)) != null;
                case "checkbox":
                    return _browser.CheckBox(Find.ById(fieldId)) != null;
                case "button":
                    return _browser.Button(Find.ById(fieldId)) != null;
                default:
                    return false;
            }
        }

        /// <summary>
        /// This method checks the browser for the specific field that you have specfied
        /// </summary>
        /// <param name="fieldType">The type of field that you are looking for (textbox/select/checkbox/button).</param>
        /// <param name="fieldName">The name of the field that you are looking for.</param>
        /// <returns>Boolean value indicating whether the field was found or not.</returns>
        public bool FieldExistsUsingName(string fieldType, string fieldName)
        {
            switch (fieldType.ToLower())
            {
                case "textbox":
                    return _browser.ElementOfType<TextFieldExtended>(Find.ByName(fieldName)) != null;
                case "select":
                    return _browser.SelectList(Find.ByName(fieldName)) != null;
                case "checkbox":
                    return _browser.CheckBox(Find.ByName(fieldName)) != null;
                case "button":
                    return _browser.Button(Find.ByName(fieldName)) != null;
                default:
                    return false;
            }
        }

        /// <summary>
        /// This method checks the browser for to see if the specified Field is enabled.
        /// </summary>
        /// <param name="fieldType">The type of field that you are looking for (textbox/select/checkbox/button).</param>
        /// <param name="fieldId">The id of the field that you are looking for.</param>
        /// <returns>Boolean value indicating whether the field was enabled or not.</returns>
        public bool FieldEnabled(string fieldType, string fieldId)
        {
            switch (fieldType.ToLower())
            {
                case "textbox":
                    return _browser.ElementOfType<TextFieldExtended>(Find.ById(fieldId)).Enabled;
                case "select":
                    return _browser.SelectList(Find.ById(fieldId)).Enabled;
                case "checkbox":
                    return _browser.CheckBox(Find.ById(fieldId)).Enabled;
                case "button":
                    return _browser.Button(Find.ById(fieldId)).Enabled;
                default:
                    return false;
            }
        }

        /// <summary>
        /// This method returns the value of an attribute from a field.
        /// </summary>
        /// <param name="fieldId">The field's ID</param>
        /// <param name="fieldType">The type of field that you are looking for.</param>
        /// <param name="attributeName">The name of the attribute that you are looking for</param>
        /// <returns>A string containing the field attribute value.</returns>
        public string ReturnFieldAttribute(string fieldId, string fieldType, string attributeName)
        {
            switch (fieldType.ToLower())
            {
                case "textbox":
                    return _browser.ElementOfType<TextFieldExtended>(Find.ByName(fieldId)).GetAttributeValue(attributeName);
                case "select":
                    return _browser.SelectList(Find.ByName(fieldId)).GetAttributeValue(attributeName);
                case "checkbox":
                    return _browser.CheckBox(Find.ByName(fieldId)).GetAttributeValue(attributeName);
                case "button":
                    return _browser.Button(Find.ByName(fieldId)).GetAttributeValue(attributeName);
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// This method returns a valud from the input field with the id of the fieldId parameter
        /// </summary>
        /// <param name="fieldId">The Textbox's ID</param>
        /// <returns>A string containing the result.</returns>
        public string ReturnTextBoxValue(string fieldId)
        {
            string result = string.Empty;
            var field = _browser.ElementOfType<TextFieldExtended>(Find.ById(fieldId));

            if (field != null)
            {
                result = field.Value ?? string.Empty;
            }

            return result;
        }

        /// <summary>
        /// This method returns the inner HTML of the HTML tag.
        /// </summary>
        /// <param name="selector">The selector to find the HTML tag.</param>
        /// <returns>A string containing the result.</returns>
        public string ReturnInnerHtml(string selector)
        {
            string result = string.Empty;
            var field = _browser.Element(Find.BySelector(selector));

            if (field != null)
            {
                result = field.InnerHtml ?? string.Empty;
            }

            return result;
        }

        /// <summary>
        /// This method sets a TextBox fields value to the value
        /// </summary>
        /// <param name="fieldId">The Textbox's ID</param>
        /// <param name="value">The value that should be put in the field.</param>
        /// <returns>A boolean value indicating whether the field exists.</returns>
        public bool SetTextBoxValue(string fieldId, string value)
        {
            var result = false;
            var field = _browser.ElementOfType<TextFieldExtended>(Find.ById(fieldId));

            if (field != null)
            {
                field.Value = value;
                result = true;
            }
            return result;
        }

        /// <summary>
        /// This method gets the selected value from the select list that corresponds to the FieldId.
        /// </summary>
        /// <param name="fieldId">The select list's ID</param>
        /// <returns>A string containing the result.</returns>
        public string ReturnSelectedItem(string fieldId)
        {
            string result = string.Empty;
            var field = _browser.SelectList(Find.ById(fieldId));

            if (field != null && field.SelectedItem != null)
            {
                result = field.SelectedItem;
            }
            return result;
        }

        /// <summary>
        /// This method sets the selected value of the select list that corresponds to the FieldId.
        /// </summary>
        /// <param name="fieldId">The select list's ID</param>
        /// <param name="value">The value that you are setting.</param>
        /// <returns>A boolean value indicating whether the select list was found.</returns>
        public bool SetSelectedItem(string fieldId, string value)
        {
            bool result = false;
            var field = _browser.SelectList(Find.ById(fieldId));

            if (field != null)
            {
                result = true;
                field.SelectByValue(value);
            }
            return result;
        }

        /// <summary>
        /// This method fires the jsToRun javascript on the page.
        /// </summary>
        /// <param name="jsToRun">The script that you want to run on the browser page.</param>
        public void FireJs(string jsToRun)
        {
            _browser.Eval(jsToRun);
        }

        /// <summary>
        /// This method sets the checkbox that corresponds with the FieldId
        /// </summary>
        /// <param name="fieldId">The select list's ID</param>
        /// <returns>A boolean value indicating if the checkbox is checked or not.</returns>
        public bool GetCheckboxCheckedStatus(string fieldId)
        {
            bool result = false;
            var field = _browser.CheckBox(Find.ById(fieldId));

            if (field != null)
            {
                result = field.Checked;
            }
            return result;
        }

        /// <summary>
        /// This method sets the checkbox that corresponds with the FieldId
        /// </summary>
        /// <param name="fieldId">The select list's ID</param>
        /// <param name="isChecked">The value that you are setting.</param>
        /// <returns>A boolean value indicating whether the select list was found.</returns>
        public bool SetCheckbox(string fieldId, bool isChecked)
        {
            bool result = false;
            var field = _browser.CheckBox(Find.ById(fieldId));

            if (field != null)
            {
                result = true;
                field.Checked = isChecked;
            }
            return result;
        }

        /// <summary>
        /// This method clicks the button that has an id of FieldId
        /// </summary>
        /// <param name="fieldId">The button's ID</param>
        /// <returns>A boolean value indicating whether the select list was found.</returns>
        public bool ClickButton(string fieldId)
        {
            bool result = false;
            var field = _browser.Button(Find.ById(fieldId));

            if (field != null)
            {
                result = true;
                field.Click();
            }
            return result;
        }
    }
}
