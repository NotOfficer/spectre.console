global using System;
global using System.Collections;
global using System.Collections.Generic;
global using System.ComponentModel;
global using System.Diagnostics;
global using System.Diagnostics.CodeAnalysis;
global using System.Globalization;
global using System.IO;
global using System.Linq;
global using System.Net;
global using System.Reflection;
global using System.Runtime.CompilerServices;
global using System.Runtime.InteropServices;
global using System.Text;
global using System.Text.RegularExpressions;
global using System.Threading;
global using System.Threading.Tasks;
global using System.Xml;
global using Spectre.Console.Enrichment;
global using Spectre.Console.Internal;
global using Spectre.Console.Rendering;
global using Wcwidth;
#if NET9_0_OR_GREATER
global using LockObject = System.Threading.Lock;
#else
global using LockObject = object;
#endif