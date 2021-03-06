﻿using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.HtmlRuby,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class HtmlRubyEditorDescriptor : AceEditorDescriptor
    {
    }
}