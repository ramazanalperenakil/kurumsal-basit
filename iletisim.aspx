<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="iletişim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    

<!-- Page Conttent -->
<main class="page-content">
    
    <!-- Start Google-map Area -->
    <div class="google-map pb-5 container-fluid">
          <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3178.3803308009606!2d33.228029039131904!3d37.19119489015157!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14d98d16b7537945%3A0xff27bc68fb5b5470!2sCumhuriyet%2C%20Atat%C3%BCrk%20Cd.%2066%2C%20Karaman%20Merkez%2FKaraman!5e0!3m2!1str!2str!4v1606658613683!5m2!1str!2str" width="1500" height="250" style="border:0;" aria-hidden="false" tabindex="0"></iframe>
    </div>
    <!-- End google-map Area -->
    <br />
    <div class="contact-form-area pt-5">
        <div class="container">
            <div class="row align-items-center">
                
                <div class="col-lg-6 col-md-6 col-12">
                    <div class="form_wrapper form-style-1">
                        <div class="contact-title">
                           <div class="title-3">
                               <h3>Get In Touch</h3>
                           </div>
                        </div>
                        <div class="form-inner-box-warp">
                            <form id="contact-form" action="assets/php/mail.php">
                                <div class="row">
                                    <div class="col-lg-12 mb-30">
                                        <input name="name" type="text" placeholder="Name*">
                                    </div>
                                    <div class="col-lg-12  mb-30">
                                        <input name="email" type="email" placeholder="Email*">
                                    </div>
                                    <div class="col-lg-12  mb-30">
                                        <input type="text" placeholder="Subject*">
                                    </div>
                                    <div class="col-lg-12  mb-30">
                                        <textarea name="message"  placeholder="Your Message*"></textarea>
                                    </div>
                                    <div class="col-lg-12">
                                        <button type="submit" class="submit-btn default-btn">Send</button>
                                        <p class="form-messege"></p>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
              
                <div class="col-lg-5 offset-lg-1 col-md-6">
                    <div class="contact-info-wrapper">
                        <div class="contact-title">
                           <div class="title-3">
                               <h3>Contact Us</h3>
                           </div>
                        </div>
                        
                        <div class="contact-info">
                        <ul>
                            <li>
                                <div class="contact-text d-flex align-items-center">
                                    <i class="fa fa-phone"></i> 
                                    <p>
                                        <a href="#">+012 345 678 102</a>
                                        <a href="#">+012 345 678 102</a>
                                    </p>
                                </div>
                            </li>
                            <li>
                                <div class="contact-text d-flex align-items-center">
                                    <i class="fa fa-globe"></i> 
                                    <p>
                                        <a href="#"> urname@email.com</a>
                                        <a href="#"> urwebsite@name.com</a>
                                    </p>
                                </div>
                            </li>
                            <li>
                                <div class="contact-text d-flex align-items-center">
                                    <i class="fa fa-map-marker"></i>
                                    <p>
                                        Address goes here, <br>street, Crossroad 123.
                                    </p>
                                </div>
                            </li>
                        </ul>
                    </div>
                    </div>
                </div>
                
            </div>
        </div>
    </div>
    
    
</main>
<!--// Page Conttent -->


</asp:Content>

