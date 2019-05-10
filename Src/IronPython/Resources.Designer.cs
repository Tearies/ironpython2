
using Microsoft.Scripting;

namespace IronPython {
    
    internal class Resources {
       
        /// <summary>
        ///   Looks up a localized string similar to couldn&apos;t find member {0}.
        /// </summary>
        internal static string CantFindMember {
            get {
                return ResourceManager.Default.GetResource("CantFindMember", "couldn't find member {0}");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to default value must be specified here.
        /// </summary>
        internal static string DefaultRequired {
            get {
                return ResourceManager.Default.GetResource("DefaultRequired", "non-default argument follows default argument");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to duplicate argument &apos;{0}&apos; in function definition.
        /// </summary>
        internal static string DuplicateArgumentInFuncDef {
            get {
                return ResourceManager.Default.GetResource("DuplicateArgumentInFuncDef", "duplicate argument '{0}' in function definition");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to duplicate keyword argument.
        /// </summary>
        internal static string DuplicateKeywordArg {
            get {
                return ResourceManager.Default.GetResource("DuplicateKeywordArg", "keyword argument repeated");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;eof&gt; while reading string.
        /// </summary>
        internal static string EofInString {
            get {
                return ResourceManager.Default.GetResource("EofInString", "'eof' while reading string");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EOF while scanning triple-quoted string.
        /// </summary>
        internal static string EofInTripleQuotedString {
            get {
                return ResourceManager.Default.GetResource("EofInTripleQuotedString", "EOF while scanning triple-quoted string");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EOL while scanning single-quoted string.
        /// </summary>
        internal static string EolInSingleQuotedString {
            get {
                return ResourceManager.Default.GetResource("EolInSingleQuotedString", "EOL while scanning single-quoted string");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to expected an indented block.
        /// </summary>
        internal static string ExpectedIndentation {
            get {
                return ResourceManager.Default.GetResource("ExpectedIndentation", "expected an indented block");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to expected name.
        /// </summary>
        internal static string ExpectedName {
            get {
                return ResourceManager.Default.GetResource("ExpectedName", "expected name");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting identifier:.
        /// </summary>
        internal static string ExpectingIdentifier {
            get {
                return ResourceManager.Default.GetResource("ExpectingIdentifier", "Expecting identifier:");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to inconsistent use of tabs and spaces in indentation.
        /// </summary>
        internal static string InconsistentWhitespace {
            get {
                return ResourceManager.Default.GetResource("InconsistentWhitespace", "inconsistent use of tabs and spaces in indentation");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to unindent does not match any outer indentation level.
        /// </summary>
        internal static string IndentationMismatch {
            get {
                return ResourceManager.Default.GetResource("IndentationMismatch", "unindent does not match any outer indentation level");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid argument value..
        /// </summary>
        internal static string InvalidArgumentValue {
            get {
                return ResourceManager.Default.GetResource("InvalidArgumentValue", "Invalid argument value.");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MakeGenericType on non-generic type.
        /// </summary>
        internal static string InvalidOperation_MakeGenericOnNonGeneric {
            get {
                return ResourceManager.Default.GetResource("InvalidOperation_MakeGenericOnNonGeneric", "MakeGenericType on non-generic type");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid parameter collection for the function..
        /// </summary>
        internal static string InvalidParameters {
            get {
                return ResourceManager.Default.GetResource("InvalidParameters", "Invalid parameter collection for the function.");
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to invalid token
        /// </summary>
        internal static string InvalidToken {
            get {
                return ResourceManager.Default.GetResource("InvalidToken", "invalid token");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to invalid syntax.
        /// </summary>
        internal static string InvalidSyntax {
            get {
                return ResourceManager.Default.GetResource("InvalidSyntax", "invalid syntax");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to object ({0}) is not creatable w/ keyword arguments.
        /// </summary>
        internal static string KeywordCreateUnavailable {
            get {
                return ResourceManager.Default.GetResource("KeywordCreateUnavailable", "object ({0}) is not creatable w/ keyword arguments");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to keywords must come before * args.
        /// </summary>
        internal static string KeywordOutOfSequence {
            get {
                return ResourceManager.Default.GetResource("KeywordOutOfSequence", "keywords must come before * args");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to type does not have {0} field.
        /// </summary>
        internal static string MemberDoesNotExist {
            get {
                return ResourceManager.Default.GetResource("MemberDoesNotExist", "type does not have {0} field");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to from __future__ imports must occur at the beginning of the file.
        /// </summary>
        internal static string MisplacedFuture {
            get {
                return ResourceManager.Default.GetResource("MisplacedFuture", "from __future__ imports must occur at the beginning of the file");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;return&apos; outside function.
        /// </summary>
        internal static string MisplacedReturn {
            get {
                return ResourceManager.Default.GetResource("MisplacedReturn", "'return' outside function");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;yield&apos; outside function.
        /// </summary>
        internal static string MisplacedYield {
            get {
                return ResourceManager.Default.GetResource("MisplacedYield", "'yield' outside function");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NEWLINE in double-quoted string.
        /// </summary>
        internal static string NewLineInDoubleQuotedString {
            get {
                return ResourceManager.Default.GetResource("NewLineInDoubleQuotedString", "NEWLINE in double-quoted string");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NEWLINE in single-quoted string.
        /// </summary>
        internal static string NewLineInSingleQuotedString {
            get {
                return ResourceManager.Default.GetResource("NewLineInSingleQuotedString", "NEWLINE in single-quoted string");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to future statement does not support import *.
        /// </summary>
        internal static string NoFutureStar {
            get {
                return ResourceManager.Default.GetResource("NoFutureStar", "future statement does not support import *");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to non-keyword arg after keyword arg.
        /// </summary>
        internal static string NonKeywordAfterKeywordArg {
            get {
                return ResourceManager.Default.GetResource("NonKeywordAfterKeywordArg", "non-keyword arg after keyword arg");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to not a chance.
        /// </summary>
        internal static string NotAChance {
            get {
                return ResourceManager.Default.GetResource("NotAChance", "not a chance");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method or operation is not implemented..
        /// </summary>
        internal static string NotImplemented {
            get {
                return ResourceManager.Default.GetResource("NotImplemented", "The method or operation is not implemented.");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to only one ** allowed.
        /// </summary>
        internal static string OneKeywordArgOnly {
            get {
                return ResourceManager.Default.GetResource("OneKeywordArgOnly", "only one ** allowed");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to only one * allowed.
        /// </summary>
        internal static string OneListArgOnly {
            get {
                return ResourceManager.Default.GetResource("OneListArgOnly", "only one * allowed");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Context must be PythonCompilerContext.
        /// </summary>
        internal static string PythonContextRequired {
            get {
                return ResourceManager.Default.GetResource("PythonContextRequired", "Context must be PythonCompilerContext");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cannot delete slot.
        /// </summary>
        internal static string Slot_CantDelete {
            get {
                return ResourceManager.Default.GetResource("Slot_CantDelete", "cannot delete slot");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cannot get slot.
        /// </summary>
        internal static string Slot_CantGet {
            get {
                return ResourceManager.Default.GetResource("Slot_CantGet", "cannot get slot");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to cannot set slot.
        /// </summary>
        internal static string Slot_CantSet {
            get {
                return ResourceManager.Default.GetResource("Slot_CantSet", "cannot set slot");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to static property &apos;{0}&apos; of &apos;{1}&apos; can only be read through a type, not an instance.
        /// </summary>
        internal static string StaticAccessFromInstanceError {
            get {
                return ResourceManager.Default.GetResource("StaticAccessFromInstanceError", "static property '{0}' of '{1}' can only be read through a type, not an instance");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to static property &apos;{0}&apos; of &apos;{1}&apos; can only be assigned to through a type, not an instance.
        /// </summary>
        internal static string StaticAssignmentFromInstanceError {
            get {
                return ResourceManager.Default.GetResource("StaticAssignmentFromInstanceError", "static property '{0}' of '{1}' can only be assigned to through a type, not an instance");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to no value for this token.
        /// </summary>
        internal static string TokenHasNoValue {
            get {
                return ResourceManager.Default.GetResource("TokenHasNoValue", "no value for this token");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to too many versions.
        /// </summary>
        internal static string TooManyVersions {
            get {
                return ResourceManager.Default.GetResource("TooManyVersions", "too many versions");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to unexpected token &apos;{0}&apos;.
        /// </summary>
        internal static string UnexpectedToken {
            get {
                return ResourceManager.Default.GetResource("UnexpectedToken", "unexpected token '{0}'");
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to future feature is not defined:.
        /// </summary>
        internal static string UnknownFutureFeature {
            get {
                return ResourceManager.Default.GetResource("UnknownFutureFeature", "future feature is not defined:");
            }
        }
    }
}
