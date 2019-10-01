﻿using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Yaml,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class YamlEditorDescriptor : AceEditorDescriptor
    {
    }
}