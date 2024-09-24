"use client"

import Layout from '@/components/ltr/layout/layout';
import axios from 'axios';
import Link from 'next/link';
import { useEffect, useState } from 'react';

const page = () => {

    const [teamMembers, setTeamMember] = useState([])

    useEffect(() => {
        fetchAuthors()
    }, [])

    const fetchAuthors = async () => {
        try {
            const response = await axios.get("https://localhost:7272/api/Author");
            setTeamMember(response.data);
        } catch (error) {
            console.error('Error fetching authors.', error);
        }
    };


    return (
        <Layout>
            <main className="page_main_wrapper">
                <section
                    className="inner-head bg-img"
                    data-image-src="assets/images/about-bg.jpg"
                >
                    <div className="container position-relative">
                        <div className="row">
                            <div className="col-sm-12">
                                <h2 className="entry-title">About Us</h2>
                                <p className="description">
                                    News from World delivers essential global news with integrity and precision. Stay informed with us.
                                </p>
                                <div className="breadcrumb">
                                    <ul className="clearfix">
                                        <li className="ib">
                                            <Link href="/">Home</Link>
                                        </li>
                                        <li className="ib current-page">About</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
                {/* END OF /. PAGE HEADER */}
                <div className="team about-content">
                    <div className="container">
                        <div className="about-title">
                            <h1>Our Mission</h1>
                            <h3>
                                To bridge diverse global communities by delivering news that informs, educates, and inspires.
                            </h3>
                            <p>
                                At News from World, our mission is to provide comprehensive and reliable news coverage from around the globe, directly to you. We are committed to maintaining the highest standards of journalism by ensuring all information is meticulously verified and presented with utmost integrity. Our goal is not only to inform but to foster understanding and engagement among our readers, helping them become well-informed global citizens. We strive to be your trusted source, bridging continents and cultures, and bringing the world closer to your doorstep.
                            </p>
                        </div>
                        <div className="row">
                            <div className="col-12">
                                <h2>Our Valuable Team Members </h2>
                            </div>
                            {/* end col-12 */}
                            {teamMembers.map((item) => (
                                <div className="col-6 col-md-3">
                                    <figure className="member">
                                        <img
                                            src={item.authorImage}
                                            className="img-fluid"
                                            alt="Image"
                                        />
                                        <figcaption>
                                            <h4>{`${item.authorName} ${item.authorSurname}`}</h4>
                                            <small>{item.authorEmail}</small>
                                        </figcaption>
                                    </figure>
                                </div>
                            ))}
                        </div>
                        <div className="about-title">
                            <h2>Bold History that Fuels the Future</h2>
                            <p>
                                Our journey began over a decade ago with a simple mission: to deliver truthful and thought-provoking news to a global audience.
                                Over the years, we have been at the forefront of major news events, providing coverage that not only reports the facts but also delves deeper to uncover the stories behind the headlines.
                                Our rich history is built on the principles of excellence, integrity, and innovation.
                                Today, we draw on this strong foundation to propel ourselves into the future, committed to enlightening and engaging more people than ever before.
                            </p>
                        </div>
                    </div>
                </div>
            </main>
        </Layout>
    );
};

export default page;