﻿using System;
using WatiN.Core;
using WatiN.Core.Native;

namespace WatinExampleProject.Helpers
{
    /// <summary>
    /// This class allows Watin to find HTML5 Input fields (type='email',type='number' etc.), 
    /// as these are not natively supported by Watin
    /// </summary>
    [ElementTag("input", InputType = "text", Index = 0)]
    [ElementTag("input", InputType = "password", Index = 1)]
    [ElementTag("input", InputType = "textarea", Index = 2)]
    [ElementTag("input", InputType = "hidden", Index = 3)]
    [ElementTag("textarea", Index = 4)]
    [ElementTag("input", InputType = "email", Index = 5)]
    [ElementTag("input", InputType = "url", Index = 6)]
    [ElementTag("input", InputType = "number", Index = 7)]
    [ElementTag("input", InputType = "range", Index = 8)]
    [ElementTag("input", InputType = "search", Index = 9)]
    [ElementTag("input", InputType = "color", Index = 10)]
    [ElementTag("input", InputType = "tel", Index = 11)]
    public class TextFieldExtended : TextField
    {
        public TextFieldExtended(DomContainer domContainer, INativeElement element)
            : base(domContainer, element)
        {
        }

        public TextFieldExtended(DomContainer domContainer, ElementFinder finder)
            : base(domContainer, finder)
        {
        }

        public static void Register()
        {
            Type typeToRegister = typeof (TextFieldExtended);
            ElementFactory.RegisterElementType(typeToRegister);
        }
    }
}
