"use client";
import NewsDetailPage from '../page'

const NewsDetail = ({ params }) => {


    if (params.id)
        return <NewsDetailPage id={params.id} />;
};

export default NewsDetail