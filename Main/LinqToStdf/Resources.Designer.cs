﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToStdf {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LinqToStdf.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arrays must be assignable..
        /// </summary>
        internal static string ArraysMustBeAssignable {
            get {
                return ResourceManager.GetString("ArraysMustBeAssignable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to STDF only supports arrays up to {0} in length for field index {1} of {2}..
        /// </summary>
        internal static string ArrayTooLong {
            get {
                return ResourceManager.GetString("ArrayTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nested iterations cannot be triggered inside RecordFilter implementations when caching is enabled..
        /// </summary>
        internal static string CachingReEntrancy {
            get {
                return ResourceManager.GetString("CachingReEntrancy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot write record without being able to infer the endianness of the output file. Use a StartOfStreamRecord or Far as the first record..
        /// </summary>
        internal static string CannotInferEndianness {
            get {
                return ResourceManager.GetString("CannotInferEndianness", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ldc&lt;T&gt; does not support T is {0}..
        /// </summary>
        internal static string CodeGen_UnsupportedGenericLdc {
            get {
                return ResourceManager.GetString("CodeGen_UnsupportedGenericLdc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not assignable from StdfRecord..
        /// </summary>
        internal static string ConverterTargetNotStdfRecord {
            get {
                return ResourceManager.GetString("ConverterTargetNotStdfRecord", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} bytes of corrupt data found at offset {1}..
        /// </summary>
        internal static string CorruptDataMessage {
            get {
                return ResourceManager.GetString("CorruptDataMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directory does not exist ({0})..
        /// </summary>
        internal static string DirectoryNotFound {
            get {
                return ResourceManager.GetString("DirectoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected {0} more bytes while trying to read {1}..
        /// </summary>
        internal static string EndOfStreamException {
            get {
                return ResourceManager.GetString("EndOfStreamException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The stream of records ended prematurely. The last record consumed must be an EndOfStreamRecord..
        /// </summary>
        internal static string EndWithoutEOS {
            get {
                return ResourceManager.GetString("EndWithoutEOS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End of Stream encountered while reading record header..
        /// </summary>
        internal static string EOFInHeader {
            get {
                return ResourceManager.GetString("EOFInHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End of Stream encountered while reading record contents..
        /// </summary>
        internal static string EOFInRecordContent {
            get {
                return ResourceManager.GetString("EOFInRecordContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End of Stream encountered while in seek mode..
        /// </summary>
        internal static string EOFInSeekMode {
            get {
                return ResourceManager.GetString("EOFInSeekMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot modify the filters after records have been read..
        /// </summary>
        internal static string ErrorFiltersLocked {
            get {
                return ResourceManager.GetString("ErrorFiltersLocked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The FAR record length was not reported as 2..
        /// </summary>
        internal static string FarLengthError {
            get {
                return ResourceManager.GetString("FarLengthError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The FAR could not be fully read..
        /// </summary>
        internal static string FarReadError {
            get {
                return ResourceManager.GetString("FarReadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The FAR record sub-type was not reported as 10..
        /// </summary>
        internal static string FarRecordSubTypeError {
            get {
                return ResourceManager.GetString("FarRecordSubTypeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The FAR record type was not reported as 0..
        /// </summary>
        internal static string FarRecordTypeError {
            get {
                return ResourceManager.GetString("FarRecordTypeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fixed-length string layouts must provide a missing value..
        /// </summary>
        internal static string FixedLengthStringMustHaveDefault {
            get {
                return ResourceManager.GetString("FixedLengthStringMustHaveDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to V4 sequence rules prohibit {0} int the state &quot;{1}&quot;..
        /// </summary>
        internal static string InitialSequenceError {
            get {
                return ResourceManager.GetString("InitialSequenceError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The data type code {0} is not defined in the STDF spec..
        /// </summary>
        internal static string InvalidGdrDataTypeCode {
            get {
                return ResourceManager.GetString("InvalidGdrDataTypeCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The unknown record type does not match the type of the converter..
        /// </summary>
        internal static string InvalidRecordConverstionDefault {
            get {
                return ResourceManager.GetString("InvalidRecordConverstionDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can only save the dynamic assembly if debug is turned on and code has been generated..
        /// </summary>
        internal static string InvalidSaveAssembly {
            get {
                return ResourceManager.GetString("InvalidSaveAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FieldIndex must be greater than or equal to zero..
        /// </summary>
        internal static string NegativeFieldIndex {
            get {
                return ResourceManager.GetString("NegativeFieldIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Offset must be &gt;= 0..
        /// </summary>
        internal static string NegativeOffset {
            get {
                return ResourceManager.GetString("NegativeOffset", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BitArray fields do not support array layout attributes..
        /// </summary>
        internal static string NoBitArrayArrays {
            get {
                return ResourceManager.GetString("NoBitArrayArrays", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Silverlight doesn&apos;t support debug mode..
        /// </summary>
        internal static string NoDebugInSilverlight {
            get {
                return ResourceManager.GetString("NoDebugInSilverlight", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The stdf field indexes for type {0} are not consecutive and/or unique..
        /// </summary>
        internal static string NonConsecutiveFieldIndexDefault {
            get {
                return ResourceManager.GetString("NonConsecutiveFieldIndexDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no contingency for writing &quot;NULL&quot; to field index {0} of {1}..
        /// </summary>
        internal static string NonNullableField {
            get {
                return ResourceManager.GetString("NonNullableField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} has no registered unconverter..
        /// </summary>
        internal static string NoRegisteredUnconverter {
            get {
                return ResourceManager.GetString("NoRegisteredUnconverter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to String fields do not support array layout attributes..
        /// </summary>
        internal static string NoStringArrays {
            get {
                return ResourceManager.GetString("NoStringArrays", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The offset is to large to be stored in an StdfRecord..
        /// </summary>
        internal static string OffsetTooLarge {
            get {
                return ResourceManager.GetString("OffsetTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to STDF only supports records up to 65535 bytes long..
        /// </summary>
        internal static string RecordTooLong {
            get {
                return ResourceManager.GetString("RecordTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shared length arrays have differing lengths (length field index {0})..
        /// </summary>
        internal static string SharedLengthViolation {
            get {
                return ResourceManager.GetString("SharedLengthViolation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot start a new file before ending the current one..
        /// </summary>
        internal static string SOFBeforeEOF {
            get {
                return ResourceManager.GetString("SOFBeforeEOF", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StdfStringLayoutAttribute can only define fields of type string..
        /// </summary>
        internal static string StdfStringLayoutNonString {
            get {
                return ResourceManager.GetString("StdfStringLayoutNonString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stdf strings must be at least 1 character long..
        /// </summary>
        internal static string StdfStringLessThanOne {
            get {
                return ResourceManager.GetString("StdfStringLessThanOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to STDF only supports strings up to 255 characters long..
        /// </summary>
        internal static string StringTooLong {
            get {
                return ResourceManager.GetString("StringTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t unconvert unknown records with the wrong Endianness..
        /// </summary>
        internal static string UnconvertEndianMismatch {
            get {
                return ResourceManager.GetString("UnconvertEndianMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Array length fields must be either ushort or byte ({0} not supported)..
        /// </summary>
        internal static string UnsupportedArrayLengthType {
            get {
                return ResourceManager.GetString("UnsupportedArrayLengthType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Don&apos;t know how to write {0} to a GDR..
        /// </summary>
        internal static string UnsupportedGdrDataType {
            get {
                return ResourceManager.GetString("UnsupportedGdrDataType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No reader method for {0}..
        /// </summary>
        internal static string UnsupportedReaderType {
            get {
                return ResourceManager.GetString("UnsupportedReaderType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This record converter factory does not support Stdf fields of type {0}..
        /// </summary>
        internal static string UnsupportedStdfFieldTypeMessage {
            get {
                return ResourceManager.GetString("UnsupportedStdfFieldTypeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No writer method for {0}..
        /// </summary>
        internal static string UnsupportedWriterType {
            get {
                return ResourceManager.GetString("UnsupportedWriterType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to after ATR.
        /// </summary>
        internal static string V4ContentState_AfterAtr {
            get {
                return ResourceManager.GetString("V4ContentState_AfterAtr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to after FAR.
        /// </summary>
        internal static string V4ContentState_AfterFar {
            get {
                return ResourceManager.GetString("V4ContentState_AfterFar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to after MIR.
        /// </summary>
        internal static string V4ContentState_AfterMir {
            get {
                return ResourceManager.GetString("V4ContentState_AfterMir", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to after MRR.
        /// </summary>
        internal static string V4ContentState_AfterMrr {
            get {
                return ResourceManager.GetString("V4ContentState_AfterMrr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to after RDR.
        /// </summary>
        internal static string V4ContentState_AfterRdr {
            get {
                return ResourceManager.GetString("V4ContentState_AfterRdr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to after SDR.
        /// </summary>
        internal static string V4ContentState_AfterSdr {
            get {
                return ResourceManager.GetString("V4ContentState_AfterSdr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to at end of file.
        /// </summary>
        internal static string V4ContentState_AtEOF {
            get {
                return ResourceManager.GetString("V4ContentState_AtEOF", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to at start of file.
        /// </summary>
        internal static string V4ContentState_AtSOF {
            get {
                return ResourceManager.GetString("V4ContentState_AtSOF", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to before start of file.
        /// </summary>
        internal static string V4ContentState_BeforeSOF {
            get {
                return ResourceManager.GetString("V4ContentState_BeforeSOF", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to in the STDF body.
        /// </summary>
        internal static string V4ContentState_StdfBody {
            get {
                return ResourceManager.GetString("V4ContentState_StdfBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to in unknown state.
        /// </summary>
        internal static string V4ContentState_Unknown {
            get {
                return ResourceManager.GetString("V4ContentState_Unknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to write outside of a StartOfStreamRecord/EndOfStreamRecord pair..
        /// </summary>
        internal static string WriteOutsideSOSEOS {
            get {
                return ResourceManager.GetString("WriteOutsideSOSEOS", resourceCulture);
            }
        }
    }
}
