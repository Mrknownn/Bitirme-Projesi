"use client"

import GoogleMapComponents from "@/components/ltr/google-map/google-map";
import Layout from "@/components/ltr/layout/layout";
import Link from "next/link";
import StickyBox from "react-sticky-box";

const page = () => {

    return (
        <Layout>
            <div className="page-title">
                <div className="container">
                    <div className="align-items-center row">
                        <div className="col">
                            <h1 className="mb-sm-0">
                                <strong>Contact</strong>
                            </h1>
                        </div>
                        <div className="col-12 col-sm-auto">
                            <nav aria-label="breadcrumb">
                                <ol className="breadcrumb d-inline-block">
                                    <li className="breadcrumb-item">
                                        <Link href="/">Home</Link>
                                    </li>
                                    <li className="breadcrumb-item active" aria-current="page">
                                        Contact
                                    </li>
                                </ol>
                            </nav>
                        </div>
                    </div>
                </div>
            </div>
            {/* END OF /. PAGE TITLE */}

            {/* *** START PAGE MAIN CONTENT *** */}
            <main className="page_main_wrapper">
                <div className="container">
                    <div className="row row-m">
                        <div className="col-sm-8 col-md-12 main-content col-p">
                            <StickyBox>
                                {/* START CONTACT INFO */}
                                <div className="panel_inner">
                                    <div className="panel_header">
                                        <h4>
                                            <strong>Contact</strong> Info
                                        </h4>
                                    </div>
                                    <div className="panel_body">
                                        <address>
                                            <strong>NFW, Inc.</strong>
                                            <br /> İkizce Mahallesi İkizce Sokak
                                            <br /> 100 P.K. 44900 Yeşilyurt / MALATYA
                                            <br /> <abbr title="Phone">P:</abbr> (+90) 553 661 11 24
                                        </address>
                                        <address>
                                            <strong>NFW, Inc.</strong>
                                            <br /> İkizce Mahallesi İkizce Sokak
                                            <br /> 100 P.K. 44900 Yeşilyurt / MALATYA
                                            <br /> <abbr title="Phone">P:</abbr> (+90) 551 025 81 81
                                        </address>
                                        <address>
                                            <strong>Mail:</strong>
                                            <br /> <a href="mailto:#">newsfromworld@gmail.com</a>
                                        </address>
                                    </div>
                                </div>
                            </StickyBox>
                        </div>
                    </div>
                    <div className="panel_inner">
                        <div className="panel_body">
                            {/* The element that will contain Google Map. This is used in both the Javascript and CSS above. */}
                            <GoogleMapComponents />
                        </div>
                    </div>
                </div>
            </main>
            {/* *** END OF /. PAGE MAIN CONTENT *** */}
        </Layout>

    );
};

export default page;