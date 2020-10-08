using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Windows.Automation;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public class AutomationMethods
    {

        public AutomationElement setParentElement(string elementString)
        {

            int ct = 0;

            AutomationElement elementParent;

            do
            {
                elementParent = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.NameProperty, elementString));
                ct++;
                Thread.Sleep(100);

            }
            while (elementParent == null && ct < 20);

            if (elementParent == null && ct == 20)
            {
                MessageBox.Show("EmptyElement");
            }

            return elementParent;
        }

        

        // Sets Parent Element , waits up to 3 seconds to find the element. 
        public AutomationElement setParentElementById(string elementString)
        {

            int ct = 0;

            AutomationElement elementParent;

            do
            {
                elementParent = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.AutomationIdProperty, elementString));
                ct++;
                Thread.Sleep(100);

            }
            while (elementParent == null && ct < 20);

            if (elementParent == null && ct == 20)
            {
                MessageBox.Show("EmptyElement");
            }

            Thread.Sleep(500);

            return elementParent;
        }

        // Passes in Child Elements. If the Parent Element is still Null does not attempt to set Child. Checks for Element to be enabled if the 
        // passed in element is maked False on skipElement. Otherwise passes back up as True. Loops to check back for being Enabled if it is not skipped.
        public AutomationElement setChildElementById(AutomationElement parentElement, string idProperty, bool skipElement)
        {

            bool elementCheck = false;
            int ct = 0;
            AutomationElement childElement = null;

            do
            {

                if (parentElement != null)
                {
                    childElement = parentElement.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.AutomationIdProperty, idProperty));
                }
                elementCheck = enabledCheck(childElement);
                ct++;
                if (skipElement == true)
                {
                    elementCheck = true;
                }
                Thread.Sleep(100);
            }
            while (elementCheck == false && ct < 10);

            return childElement;
        }

        // Passes in Child Elements. If the Parent Element is still Null does not attempt to set Child. Checks for Element to be enabled if the 
        // passed in element is maked False on skipElement. Otherwise passes back up as True. Loops to check back for being Enabled if it is not skipped.
        public AutomationElement setChildElementByName(AutomationElement parentElement, string nameProperty, bool skipElement)
        {

            AutomationElement childElement = null;
            bool elementCheck = false;
            int ct = 0;

            do
            {
                if (parentElement != null)
                {
                    childElement = parentElement.FindFirst(TreeScope.Descendants, new PropertyCondition(AutomationElement.NameProperty, nameProperty));
                }
                elementCheck = enabledCheck(childElement);
                ct++;
                if (skipElement == true)
                {
                    elementCheck = true;
                }
                Thread.Sleep(100);
            }
            while (elementCheck == false && ct < 10);

            return childElement;
        }

        // Presses the button of passed in Element
        public void invokeButtonPress(AutomationElement sentElement)
        {
            bool elementCheck = false;
            elementCheck = enabledCheck(sentElement);

            if (elementCheck == true)
            {
                InvokePattern invokePattern = sentElement.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
                invokePattern.Invoke();
            }
        }

        public void selectRadioButton(AutomationElement sentElement)
        {
            bool elementCheck = false;
            elementCheck = enabledCheck(sentElement);

            if (elementCheck == true)
            {
                SelectionItemPattern selectionPattern = (SelectionItemPattern)sentElement.GetCurrentPattern(SelectionItemPattern.Pattern);
                selectionPattern.Select();
            }
        }

        public void expandItem(AutomationElement sentElement) 
        {
            bool elementCheck = false;
            elementCheck = enabledCheck(sentElement);

            if (elementCheck == true)
            {
                ExpandCollapsePattern expandPattern = (ExpandCollapsePattern)sentElement.GetCurrentPattern(ExpandCollapsePattern.Pattern);
                expandPattern.Expand();
            }
        
        }

        public void selectItem(AutomationElement sentElement) 
        {
            bool elementCheck = false;
            elementCheck = enabledCheck(sentElement);

            if (elementCheck == true)
            {
                SelectionItemPattern selectionPattern = (SelectionItemPattern)sentElement.GetCurrentPattern(SelectionItemPattern.Pattern);
                selectionPattern.Select();
            }
        
        }

        // Sets values in Elements like Text Boxes
        public void setValue(AutomationElement sentElement, string value)
        {
            if (sentElement != null)
            {
                ValuePattern valuePattern = (ValuePattern)sentElement.GetCurrentPattern(ValuePattern.Pattern);
                valuePattern.SetValue(value);
            }
        }


        public void selectComboBoxItem(AutomationElement sentElement, int indexToSelect)
        {

            if (sentElement == null)
                throw new Exception("Combo Box not found");


            //Get the all the list items in the ComboBox
            AutomationElementCollection comboboxItem = sentElement.FindAll(TreeScope.Children, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.ListItem));


            ExpandCollapsePattern expandPattern = (ExpandCollapsePattern)sentElement.GetCurrentPattern(ExpandCollapsePattern.Pattern);
            expandPattern.Expand();


            //Index to set in combo box
            AutomationElement itemToSelect = comboboxItem[indexToSelect];

            //Finding the pattern which need to select
            SelectionItemPattern selectPattern = (SelectionItemPattern)itemToSelect.GetCurrentPattern(SelectionItemPattern.Pattern);
            selectPattern.Select();

        }

        // Function checkes passed in Elements as being Enabled or Not, Skips Null elements to prevent Instance Errors
        public bool enabledCheck(AutomationElement sentElement)
        {

            bool check = false;

            if (sentElement != null)
            {
                check = (bool)sentElement.GetCurrentPropertyValue(AutomationElement.IsEnabledProperty);
            }

            return check;

        }

        public void enabledMessagedCheck(AutomationElement sentElement)
        {
            bool check = false;
            if (sentElement != null)
            {
                check = (bool)sentElement.GetCurrentPropertyValue(AutomationElement.IsEnabledProperty);
            }

            if (check == true)
            {
                MessageBox.Show("Enabled");
            }
            else
            {
                MessageBox.Show("Not Enabled");
            }
        }

        public void supportedPatterns(AutomationElement sentElement)
        {
            AutomationPattern[] patterns = sentElement.GetSupportedPatterns();
            foreach (AutomationPattern pattern in patterns)
            {
                MessageBox.Show("ProgrammaticName: " + pattern.ProgrammaticName + " " + "PatternName: " + Automation.PatternName(pattern));
            }
        
        }

        public List<AutomationElement> GetChildren(AutomationElement parent)
        {
            if (parent == null)
            {
                throw new ArgumentException();
            }

            AutomationElementCollection collection = parent.FindAll(TreeScope.Children, Condition.TrueCondition);

            if (collection != null)
            {
                List<AutomationElement> result = new List<AutomationElement>(collection.Cast<AutomationElement>());
                return result;
            }
            else
            {
                return null;
            }

        }

        public string getID(AutomationElement sentElement) 
        {
            string Id = "";
            if (sentElement != null ) {
            
                Id = sentElement.GetCurrentPropertyValue(AutomationElement.AutomationIdProperty) as string;
                return Id;
            }
            else {
                return "Empty Element";
            }
        }


        public void elementIsNull(AutomationElement sentElement)
        {
            if (sentElement != null)
            {
                MessageBox.Show("Success");
            }
            else 
            {
                MessageBox.Show("Failure");
            }
        
        }


        /*
         List<AutomationElement> elementList = automation.GetChildren(sentElement);
            foreach (var list in elementList)
            {
                string name = list.Current.Name;
                names.Add(name);
            }

            var message = string.Join(Environment.NewLine, names);
            string count = elementList.Count.ToString();
            MessageBox.Show(count + message);
         */

    }
}