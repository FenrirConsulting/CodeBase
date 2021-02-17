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

namespace HandsFreeInda
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

            return elementParent;
        }

        // Sets Parent Element , waits up to 3 seconds to find the element. Looks for a time stamp with a range of up to 6 seconds before and after 
        // the Now() time. Once it finds a label with the right name and time it breaks out of the loop and passes Element back up.
        public AutomationElement setParentElementWithTime(string elementString)
        {

            int ct = 0;

            AutomationElement elementParent = null;

            do
            {

                string dateFormat = "hh:mm:ss tt";
                DateTime nowTime = DateTime.Now;
                DateTime nowPlusOne = nowTime.AddSeconds(1);
                DateTime nowPlusTwo = nowTime.AddSeconds(2);                
                DateTime nowPlusThree = nowTime.AddSeconds(3);
                DateTime nowPlusFour = nowTime.AddSeconds(4);
                DateTime nowPlusFive = nowTime.AddSeconds(5);
                DateTime nowPlusSix = nowTime.AddSeconds(6);
                DateTime nowPlusSeven = nowTime.AddSeconds(7);
                DateTime nowPlusEight = nowTime.AddSeconds(8);
                DateTime nowPlusNine = nowTime.AddSeconds(9);
                DateTime nowPlusTen = nowTime.AddSeconds(10);
                DateTime nowLessOne = nowTime.AddSeconds(-1);
                DateTime nowLessTwo = nowTime.AddSeconds(-2);
                DateTime nowLessThree = nowTime.AddSeconds(-3);
                DateTime nowLessFour = nowTime.AddSeconds(-4);
                DateTime nowLessFive = nowTime.AddSeconds(-5);
                DateTime nowLessSix = nowTime.AddSeconds(-6);
                DateTime nowLessSeven = nowTime.AddSeconds(-7);
                DateTime nowLessEight = nowTime.AddSeconds(-8);
                DateTime nowLessNine = nowTime.AddSeconds(-9);
                DateTime nowLessTen = nowTime.AddSeconds(-10);

                string[] timeStamps;
                timeStamps = new string[21] {
                nowTime.ToString(dateFormat),
                nowPlusOne.ToString(dateFormat),
                nowPlusTwo.ToString(dateFormat),
                nowPlusThree.ToString(dateFormat),
                nowPlusFour.ToString(dateFormat),
                nowPlusFive.ToString(dateFormat),
                nowPlusSix.ToString(dateFormat),
                nowPlusSeven.ToString(dateFormat),
                nowPlusEight.ToString(dateFormat),
                nowPlusNine.ToString(dateFormat),
                nowPlusTen.ToString(dateFormat),
                nowLessOne.ToString(dateFormat),
                nowLessTwo.ToString(dateFormat),
                nowLessThree.ToString(dateFormat),
                nowLessFour.ToString(dateFormat),
                nowLessFive.ToString(dateFormat),
                nowLessSix.ToString(dateFormat),
                nowLessSeven.ToString(dateFormat),
                nowLessEight.ToString(dateFormat),
                nowLessNine.ToString(dateFormat),
                nowLessTen.ToString(dateFormat)
        };

                foreach (string time in timeStamps)
                {

                    string formattedString = elementString + time;
                    elementParent = AutomationElement.RootElement.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.NameProperty, formattedString));

                    if (elementParent != null)
                    {
                        return elementParent;
                    }

                }

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
        public AutomationElement setChildElementId(AutomationElement parentElement, string idProperty, bool skipElement)
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
        public AutomationElement setChildElementName(AutomationElement parentElement, string nameProperty, bool skipElement)
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

            InvokePattern invokePattern = sentElement.GetCurrentPattern(InvokePattern.Pattern) as InvokePattern;
            invokePattern.Invoke();
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

        // Sets values in Elements like Text Boxes
        public void setValue(AutomationElement sentElement, string value)
        {
            if (sentElement != null)
            {
                ValuePattern valuePattern = (ValuePattern)sentElement.GetCurrentPattern(ValuePattern.Pattern);
                valuePattern.SetValue(value);
            }
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
        public void closeElement(AutomationElement sentElement)
        {

            WindowPattern foundPattern = GetWindowPattern(sentElement);
            closeWindow(foundPattern);
        }


        private void closeWindow(WindowPattern windowPattern)
        {
            try
            {
                windowPattern.Close();
            }
            catch (InvalidOperationException)
            {
                // object is not able to perform the requested action
                return;
            }
        }


        private WindowPattern GetWindowPattern(AutomationElement targetControl)
        {
            WindowPattern windowPattern = null;

            try
            {
                windowPattern =
                    targetControl.GetCurrentPattern(WindowPattern.Pattern)
                    as WindowPattern;
            }
            catch (InvalidOperationException)
            {
                // object doesn't support the WindowPattern control pattern
                return null;
            }
            // Make sure the element is usable.
            if (false == windowPattern.WaitForInputIdle(10000))
            {
                // Object not responding in a timely manner
                return null;
            }
            return windowPattern;
        }

    }
}