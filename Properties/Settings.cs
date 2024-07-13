// Decompiled with JetBrains decompiler
// Type: Roblox.KeyGenerator.Properties.Settings
// Assembly: Roblox.KeyGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Roblox.KeyGenerator.Properties
{
    [CompilerGenerated]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
    internal sealed class Settings : ApplicationSettingsBase
    {
        private static Settings defaultInstance = (Settings)SettingsBase.Synchronized((SettingsBase)new Settings());

        public static Settings Default
        {
            get
            {
                Settings defaultInstance = Settings.defaultInstance;
                return defaultInstance;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool GeneratePem
        {
            get => (bool)this[nameof(GeneratePem)];
            set => this[nameof(GeneratePem)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool GenerateBlobs
        {
            get => (bool)this[nameof(GenerateBlobs)];
            set => this[nameof(GenerateBlobs)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool Base64EncodedBlobs
        {
            get => (bool)this[nameof(Base64EncodedBlobs)];
            set => this[nameof(Base64EncodedBlobs)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("PublicKeyBlob.txt")]
        public string PublicKeyBlobFileName
        {
            get => (string)this[nameof(PublicKeyBlobFileName)];
            set => this[nameof(PublicKeyBlobFileName)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("PrivateKeyBlob.txt")]
        public string PrivateKeyBlobFileName
        {
            get => (string)this[nameof(PrivateKeyBlobFileName)];
            set => this[nameof(PrivateKeyBlobFileName)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("PrivateKey.pem")]
        public string PrivateKeyPemFileName
        {
            get => (string)this[nameof(PrivateKeyPemFileName)];
            set => this[nameof(PrivateKeyPemFileName)] = (object)value;
        }
    }
}
