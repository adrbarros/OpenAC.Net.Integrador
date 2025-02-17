﻿// ***********************************************************************
// Assembly         : OpenAC.Net.Integrador
// Author           : RFTD
// Created          : 02-19-2018
//
// Last Modified By : RFTD
// Last Modified On : 02-19-2018
// ***********************************************************************
// <copyright file="OpenIntegrador.cs" company="OpenAC .Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2014 - 2021 Projeto OpenAC .Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace OpenAC.Net.Integrador
{
    /// <summary>
    /// Class NumeroSessaoEventArgs.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public sealed class NumeroSessaoEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumeroSessaoEventArgs"/> class.
        /// </summary>
        /// <param name="sessao">The sessao.</param>
        public NumeroSessaoEventArgs(int sessao)
        {
            Sessao = sessao;
        }

        /// <summary>
        /// Gets or sets the sessao.
        /// </summary>
        /// <value>The sessao.</value>
        public int Sessao { get; set; }
    }
}