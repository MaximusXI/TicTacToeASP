#pragma checksum "D:\ASP\TicTacToe\TicTacToe\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "227c417c456b0c7f742a49ac06512696409c0780"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\ASP\TicTacToe\TicTacToe\Views\_ViewImports.cshtml"
using TicTacToe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP\TicTacToe\TicTacToe\Views\_ViewImports.cshtml"
using TicTacToe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"227c417c456b0c7f742a49ac06512696409c0780", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"251dceebe3e6747e5343b222378328fe467f6241", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\ASP\TicTacToe\TicTacToe\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "227c417c456b0c7f742a49ac06512696409c07803784", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.7.0/css/all.css""
      integrity=""sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ""
      crossorigin=""anonymous"">
<div class=""container-fluid text-center"">

    <!-- Inform area for player's turn -->
    <h4 id=""screen"" style=""color: white;"">
        PLAYER 1 TURN FOLLOWS
    </h4>
</div>
<br>
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-lg-4"">   </div>
        <div class=""col-lg-4"">
            <!-- Playing Canvas -->
            <center>
                <table>
                    <tr>
                        <td colspan=""3"">
                    </tr>
                    <tr>
                        <td>
                            <button id=""btn1"" class=""sq1 r""></button>
                        </td>
                        <td>
                            <button id=""btn2"" class="" sq2 r""></button>
                        </td>
                        <t");
            WriteLiteral(@"d>
                            <button id=""btn3"" class=""sq3 r""></button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <button id=""btn4"" class=""sq4 r""></button>
                        </td>
                        <td>
                            <button id=""btn5"" class=""sq5 r""></button>
                        </td>
                        <td>
                            <button id=""btn6"" class=""sq6 r""></button>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <button id=""btn7"" class=""sq7 r""></button>
                        </td>
                        <td>
                            <button id=""btn8"" class=""sq8 r""></button>
                        </td>
                        <td>
                            <button id=""btn9"" class=""sq9 r""></button>
                        </td>
                    ");
            WriteLiteral(@"</tr>
                </table>
                <br>
                <br>

                <!-- Reset button for Game -->
                <input type=""button""
                       class=""reset btn btn-lg btn-danger btn-block""
                       value=""RESET"" onClick=""reset()"" />
            </center>
        </div>
        <div class=""col-lg-4""></div>
    </div>
</div>

<script>

    // Flag variable for checking Turn
    // We'll be modifying our base logic in the
    // next steps as per requirements
    var turn = 1;
    var arr = [[-1, -1, -1], [-1, -1, -1], [-1, -1, -1]];
    Boolean: bt1 = true;
    Boolean: bt2 = true;
    Boolean: bt3 = true;
    Boolean: bt4 = true;
    Boolean: bt5 = true;
    Boolean: bt6 = true;
    Boolean: bt7 = true;
    Boolean: bt8 = true;
    Boolean: bt9 = true;
    Boolean: isWon = false;
    Boolean: isDraw = false;
    $(""#btn1"").click(function () {
        if (bt1 && !isWon && !isDraw) {
            if (turn == 1) {
             ");
            WriteLiteral(@"   $(""#screen"").text(""PLAYER 2 TURN FOLLOWS"");
            } else {
                $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");
            }
            // Check sign font from font-awesome
            if (turn==1) {
                $(this).addClass(""fa fa-check"");
                arr[0][0] = 1;
                turn = 2;
                var x = check(arr);
                if (x==1) {
                    console.log(""1 won"");
                    $(""#screen"").text(""PLAYER 1 WON"");
                    isWon = true;
                }
            } else {
                $(this).addClass(""fa fa-times"");
                arr[0][0] = 2;
                turn = 1;
                var x = check(arr);
                if (x==2) {
                    console.log(""2 won"");
                    $(""#screen"").text(""PLAYER 2 WON"");
                    isWon = true;
                }
            }
            
           
            console.log(arr);
            bt1 = false;
            isDraw = dr");
            WriteLiteral(@"aw();
            if (isDraw) {
                $(""#screen"").text(""The Game is DRAW"");
            }
        }
        /*
        else {
            $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");

            // Cross sign font from font-awesome
            $(this).addClass(""fa fa-times"");
            turn = 1;
        }*/
    });
    $(""#btn2"").click(function () {
        if (bt2 && !isWon && !isDraw) {
            if (turn == 1) {
                $(""#screen"").text(""PLAYER 2 TURN FOLLOWS"");
            } else {
                $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");
            }

            // Check sign font from font-awesome
            if (turn == 1) {
                $(this).addClass(""fa fa-check"");
                arr[0][1] = 1;
                turn = 2;
                var x = check(arr);
                if (x == 1) {
                    console.log(""1 won"");
                    $(""#screen"").text(""PLAYER 1 WON"");
                    isWon = true;
                }
  ");
            WriteLiteral(@"          } else {
                $(this).addClass(""fa fa-times"");
                arr[0][1] = 2;
                turn = 1;
                var x = check(arr);
                if (x == 2) {
                    console.log(""2 won"");
                    $(""#screen"").text(""PLAYER 2 WON"");
                    isWon = true;
                }
            }
          
           
            console.log(arr);
            bt2 = false;
            isDraw = draw();
            if (isDraw) {
                $(""#screen"").text(""The Game is DRAW"");
            }
        }
       /* else {
            $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");

            // Cross sign font from font-awesome
            $(this).addClass(""fa fa-times"");
            turn = 1;
        }*/
    });
    $(""#btn3"").click(function () {
        if (bt3 && !isWon && !isDraw) {
            if (turn == 1) {
                $(""#screen"").text(""PLAYER 2 TURN FOLLOWS"");
            } else {
                $(""#screen"").t");
            WriteLiteral(@"ext(""PLAYER 1 TURN FOLLOWS"");
            }

            // Check sign font from font-awesome
            if (turn == 1) {
                $(this).addClass(""fa fa-check"");
                arr[0][2] = 1;
                turn = 2;
                var x = check(arr);
                if (x == 1) {
                    console.log(""1 won"");
                    $(""#screen"").text(""PLAYER 1 WON"");
                    isWon = true;
                }
            } else {
                $(this).addClass(""fa fa-times"");
                arr[0][2] = 2;
                turn = 1;
                var x = check(arr);
                if (x == 2) {
                    console.log(""2 won"");
                    $(""#screen"").text(""PLAYER 2 WON"");
                    isWon = true;
                }
            }
           
           
            console.log(arr);
            bt3 = false;
            isDraw = draw();
            if (isDraw) {
                $(""#screen"").text(""The Game is DRAW"");
   ");
            WriteLiteral(@"         }
        }
       /* else {
            $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");

            // Cross sign font from font-awesome
            $(this).addClass(""fa fa-times"");
            turn = 1;
        }*/
    });
    $(""#btn4"").click(function () {
        if (bt4 && !isWon && !isDraw) {
            if (turn == 1) {
                $(""#screen"").text(""PLAYER 2 TURN FOLLOWS"");
            } else {
                $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");
            }

            // Check sign font from font-awesome
            if (turn == 1) {
                $(this).addClass(""fa fa-check"");
                arr[1][0] = 1;
                turn = 2;
                var x = check(arr);
                if (x == 1) {
                    console.log(""1 won"");
                    $(""#screen"").text(""PLAYER 1 WON"");
                    isWon = true;
                }
            } else {
                $(this).addClass(""fa fa-times"");
                arr[1][0] = 2;
 ");
            WriteLiteral(@"               turn = 1;
                var x = check(arr);
                if (x == 2) {
                    console.log(""2 won"");
                    $(""#screen"").text(""PLAYER 2 WON"");
                    isWon = true;
                }
            }
          
            
            console.log(arr);
            bt4 = false;
            isDraw = draw();
            if (isDraw) {
                $(""#screen"").text(""The Game is DRAW"");
            }
        }
      /*  else {
            $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");

            // Cross sign font from font-awesome
            $(this).addClass(""fa fa-times"");
            turn = 1;
        }*/
    });
    $(""#btn5"").click(function () {
        if (bt5 && !isWon && !isDraw) {
            if (turn == 1) {
                $(""#screen"").text(""PLAYER 2 TURN FOLLOWS"");
            } else {
                $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");
            }

            // Check sign font from font-awesome
    ");
            WriteLiteral(@"        if (turn == 1) {
                $(this).addClass(""fa fa-check"");
                arr[1][1] = 1;
                turn = 2;
                var x = check(arr);
                if (x == 1) {
                    console.log(""1 won"");
                    $(""#screen"").text(""PLAYER 1 WON"");
                    isWon = true;
                }
            } else {
                $(this).addClass(""fa fa-times"");
                arr[1][1] = 2;
                turn = 1;
                var x = check(arr);
                if (x == 2) {
                    console.log(""2 won"");
                    $(""#screen"").text(""PLAYER 2 WON"");
                    isWon = true;
                }
            }
          
           
            console.log(arr);
            bt5 = false;
            isDraw = draw();
            if (isDraw) {
                $(""#screen"").text(""The Game is DRAW"");
            }
        }
       /* else {
            $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");

   ");
            WriteLiteral(@"         // Cross sign font from font-awesome
            $(this).addClass(""fa fa-times"");
            turn = 1;
        }*/
    });
    $(""#btn6"").click(function () {
        if (bt6 && !isWon && !isDraw) {
            if (turn == 1) {
                $(""#screen"").text(""PLAYER 2 TURN FOLLOWS"");
            } else {
                $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");
            }

            // Check sign font from font-awesome
            if (turn == 1) {
                $(this).addClass(""fa fa-check"");
                arr[1][2] = 1;
                turn = 2;
                var x = check(arr);
                if (x == 1) {
                    console.log(""1 won"");
                    $(""#screen"").text(""PLAYER 1 WON"");
                    isWon = true;
                }
            } else {
                $(this).addClass(""fa fa-times"");
                arr[1][2] = 2;
                turn = 1;
                var x = check(arr);
                if (x == 2) {
         ");
            WriteLiteral(@"           console.log(""2 won"");
                    $(""#screen"").text(""PLAYER 2 WON"");
                    isWon = true;
                }
            }
           
           
            console.log(arr);
            bt6 = false;
            isDraw = draw();
            if (isDraw) {
                $(""#screen"").text(""The Game is DRAW"");
            }
        }
      /*  else {
            $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");

            // Cross sign font from font-awesome
            $(this).addClass(""fa fa-times"");
            turn = 1;
        }*/
    });

    $(""#btn7"").click(function () {
        if (bt7 && !isWon && !isDraw) {
            if (turn == 1) {
                $(""#screen"").text(""PLAYER 2 TURN FOLLOWS"");
            } else {
                $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");
            }

            // Check sign font from font-awesome
            if (turn == 1) {
                $(this).addClass(""fa fa-check"");
                arr[2][0]");
            WriteLiteral(@" = 1;
                turn = 2;
                var x = check(arr);
                if (x == 1) {
                    console.log(""1 won"");
                    $(""#screen"").text(""PLAYER 1 WON"");
                    isWon = true;
                }
            } else {
                $(this).addClass(""fa fa-times"");
                arr[2][0] = 2;
                turn = 1;
                var x = check(arr);
                if (x == 2) {
                    console.log(""2 won"");
                    $(""#screen"").text(""PLAYER 2 WON"");
                    isWon = true;
                }
            }
      
           
            console.log(arr);
            bt7 = false;
            isDraw = draw();
            if (isDraw) {
                $(""#screen"").text(""The Game is DRAW"");
            }
        }
     /*   else {
            $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");

            // Cross sign font from font-awesome
            $(this).addClass(""fa fa-times"");
            ");
            WriteLiteral(@"turn = 1;
        }*/
    });

    $(""#btn8"").click(function () {
        if (bt8 && !isWon && !isDraw) {
            if (turn == 1) {
                $(""#screen"").text(""PLAYER 2 TURN FOLLOWS"");
            } else {
                $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");
            }

            // Check sign font from font-awesome
            if (turn == 1) {
                $(this).addClass(""fa fa-check"");
                arr[2][1] = 1;
                turn = 2;
                var x = check(arr);
                if (x == 1) {
                    console.log(""1 won"");
                    $(""#screen"").text(""PLAYER 1 WON"");
                    isWon = true;
                }
            } else {
                $(this).addClass(""fa fa-times"");
                arr[2][1] = 2;
                turn = 1;
                var x = check(arr);
                if (x == 2) {
                    console.log(""2 won"");
                    $(""#screen"").text(""PLAYER 2 WON"");
             ");
            WriteLiteral(@"       isWon = true;
                }
            }
          
           
            console.log(arr);
            bt8 = false;
            isDraw = draw();
            if (isDraw) {
                $(""#screen"").text(""The Game is DRAW"");
            }
        }
       /* else {
            $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");

            // Cross sign font from font-awesome
            $(this).addClass(""fa fa-times"");
            turn = 1;
        }*/
    });

    $(""#btn9"").click(function () {
        if (bt9 && !isWon && !isDraw) {
            if (turn == 1) {
                $(""#screen"").text(""PLAYER 2 TURN FOLLOWS"");
            } else {
                $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");
            }

            // Check sign font from font-awesome
            if (turn == 1) {
                $(this).addClass(""fa fa-check"");
                arr[2][2] = 1;
                turn = 2;
                var x = check(arr);
                if (x == 1) {
  ");
            WriteLiteral(@"                  console.log(""1 won"");
                    $(""#screen"").text(""PLAYER 1 WON"");
                    isWon = true;
                }
            } else {
                $(this).addClass(""fa fa-times"");
                arr[2][2] = 2;
                turn = 1;
                var x = check(arr);
                if (x == 2) {
                    console.log(""2 won"");
                    $(""#screen"").text(""PLAYER 2 WON"");
                    isWon = true;
                }
            }
            
           
            console.log(arr);
            bt9 = false;
            isDraw = draw();
            if (isDraw) {
                $(""#screen"").text(""The Game is DRAW"");
            }
        }
      /*  else {
            $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");

            // Cross sign font from font-awesome
            $(this).addClass(""fa fa-times"");
            turn = 1;
        }*/
    });

    /*
    function check(symbol) {
        if ($("".sq1"").has");
            WriteLiteral(@"Class(symbol) &&
            $("".sq2"").hasClass(symbol) &&
            $("".sq3"").hasClass(symbol)) {
            $("".sq1"").css(""color"", ""green"");
            $("".sq2"").css(""color"", ""green"");
            $("".sq3"").css(""color"", ""green"");
            return true;
        } else if ($("".sq4"").hasClass(symbol)
            && $("".sq5"").hasClass(symbol)
            && $("".sq6"").hasClass(symbol)) {
            $("".sq4"").css(""color"", ""green"");
            $("".sq5"").css(""color"", ""green"");
            $("".sq6"").css(""color"", ""green"");
            return true;
        } else if ($("".sq7"").hasClass(symbol)
            && $("".sq8"").hasClass(symbol)
            && $("".sq9"").hasClass(symbol)) {
            $("".sq7"").css(""color"", ""green"");
            $("".sq8"").css(""color"", ""green"");
            $("".sq9"").css(""color"", ""green"");
            return true;
        } else if ($("".sq1"").hasClass(symbol)
            && $("".sq4"").hasClass(symbol)
            && $("".sq7"").hasClass(symbol)) {
            $("".sq1""");
            WriteLiteral(@").css(""color"", ""green"");
            $("".sq4"").css(""color"", ""green"");
            $("".sq7"").css(""color"", ""green"");
            return true;
        } else if ($("".sq2"").hasClass(symbol)
            && $("".sq5"").hasClass(symbol)
            && $("".sq8"").hasClass(symbol)) {
            $("".sq2"").css(""color"", ""green"");
            $("".sq5"").css(""color"", ""green"");
            $("".sq8"").css(""color"", ""green"");
            return true;
        } else if ($("".sq3"").hasClass(symbol)
            && $("".sq6"").hasClass(symbol)
            && $("".sq9"").hasClass(symbol)) {
            $("".sq3"").css(""color"", ""green"");
            $("".sq6"").css(""color"", ""green"");
            $("".sq9"").css(""color"", ""green"");
            return true;
        } else if ($("".sq1"").hasClass(symbol)
            && $("".sq5"").hasClass(symbol)
            && $("".sq9"").hasClass(symbol)) {
            $("".sq1"").css(""color"", ""green"");
            $("".sq5"").css(""color"", ""green"");
            $("".sq9"").css(""color"", ""green"");
      ");
            WriteLiteral(@"      return true;
        } else if ($("".sq3"").hasClass(symbol)
            && $("".sq5"").hasClass(symbol)
            && $("".sq7"").hasClass(symbol)) {
            $("".sq3"").css(""color"", ""green"");
            $("".sq5"").css(""color"", ""green"");
            $("".sq7"").css(""color"", ""green"");
            return true;
        } else {
            return false;
        }
    }    */
    function check(arr) {

        if ((arr[0][0] == 1 && arr[1][1] == 1 && arr[2][2] == 1)
            || (arr[0][0] == 1 && arr[1][0] == 1 && arr[2][0] == 1)
            || (arr[0][0] == 1 && arr[0][1] == 1 && arr[0][2] == 1)
            || (arr[0][1] == 1 && arr[1][1] == 1 && arr[2][1] == 1)
            || (arr[0][2] == 1 && arr[1][2] == 1 && arr[2][2] == 1)
            || (arr[1][0] == 1 && arr[1][1] == 1 && arr[1][2] == 1)
            || (arr[2][0] == 1 && arr[2][1] == 1 && arr[2][2] == 1)
            || (arr[2][0] == 1 && arr[1][1] == 1 && arr[0][2] == 1)) {
            return 1;
        } else if ((arr[0][0] =");
            WriteLiteral(@"= 2 && arr[1][1] == 2 && arr[2][2] == 2)
            || (arr[0][0] == 2 && arr[1][0] == 2 && arr[2][0] == 2)
            || (arr[0][0] == 2 && arr[0][1] == 2 && arr[0][2] == 2)
            || (arr[0][1] == 2 && arr[1][1] == 2 && arr[2][1] == 2)
            || (arr[0][2] == 2 && arr[1][2] == 2 && arr[2][2] == 2)
            || (arr[1][0] == 2 && arr[1][1] == 2 && arr[1][2] == 2)
            || (arr[2][0] == 2 && arr[2][1] == 2 && arr[2][2] == 2)
            || (arr[2][0] == 2 && arr[1][1] == 2 && arr[0][2] == 2)) {
            return 2;
        } else {
            return -1;
        }


    }
    function reset() {
        $(""#screen"").text(""PLAYER 1 TURN FOLLOWS"");
        $(""#screen"").css(""background-color"", ""transparent"");
        $("".r"").removeClass(""fa fa-check"");
        $("".r"").removeClass(""fa fa-times"");
        turn = 1;

        // Reset Colors
        $("".sq1"").css(""color"", ""black"");
        $("".sq2"").css(""color"", ""black"");
        $("".sq3"").css(""color"", ""black"");
        ");
            WriteLiteral(@"$("".sq4"").css(""color"", ""black"");
        $("".sq5"").css(""color"", ""black"");
        $("".sq6"").css(""color"", ""black"");
        $("".sq7"").css(""color"", ""black"");
        $("".sq8"").css(""color"", ""black"");
        $("".sq9"").css(""color"", ""black"");
        arr = [[-1, -1, -1], [-1, -1, -1], [-1, -1, -1]];
        isWon = false;
        isDraw = false;
        bt1 = true;
        bt2 = true;
        bt3 = true;
        bt4 = true;
        bt5 = true;
        bt6 = true;
        bt7 = true;
        bt8 = true;
        bt9 = true;
    }
    function draw() {
        if (arr[0][0] != -1 && arr[0][1] != -1 && arr[0][2] && arr[1][0] != -1
            && arr[1][0] != -1 && arr[1][1] != -1 && arr[1][2] != -1 &&
            arr[2][0] != -1 && arr[2][1] != -1 && arr[2][2] != -1) {

            return true;
        } else {
            return false;
        }
    }

</script>
<style>
    body {
        background-color: #000000;
    }

    button {
        height: 80px;
        width: 80px;
 ");
            WriteLiteral(@"       background-color: white;
        border: 0px transparent;
        border-radius: 50%;
        margin: 4px;
        padding: 4px;
    }

    .fa {
        font-size: 48px;
        color: black;
    }

    .reset {
        padding: 8px;
    }

        .reset:hover {
            opacity: 0.8;
        }
</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
